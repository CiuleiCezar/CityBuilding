using Controller.Controllers;
using Model.POCO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using View1;

namespace Server
{
    class Server
    { 
        public static string data = null;
        static ControllerContext controllerContext = new ControllerContext();
        public static void ExecuteServer()
        {
            byte[] bytes = new Byte[8192];

            // Connection to endpoint
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and
            // listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();
                    data = null;
                    Request request = new Request();

                    // An incoming connection needs to be processed.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        request = JsonConvert.DeserializeObject<Request>(data);

                        if (request.message.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    if (request.message.Equals("/GetDistricts<EOF>"))
                    {
                        List<District> lista = controllerContext.DistrictController.GetAllDistricts();
                        var json = JsonConvert.SerializeObject(lista);
                        byte[] jsonByteForm = Encoding.ASCII.GetBytes(json);
                        handler.Send(jsonByteForm);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                    else if (request.message.Equals("/POST/District<EOF>"))
                    {
                        var district = JsonConvert.DeserializeObject<District>(request.body);
                        controllerContext.DistrictController.AddDistrict(district);
                        string message = "201 Created";
                        byte[] messageByteForm = Encoding.ASCII.GetBytes(message);
                        handler.Send(messageByteForm);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                    else if (request.message.Equals("/POST/Place<EOF>"))
                    {
                        var placeDTO = JsonConvert.DeserializeObject<PlaceDTO>(request.body);

                        Contact contact = new Contact();
                        contact.Address = placeDTO.Address;
                        contact.Email = placeDTO.Email;
                        contact.PhoneNumber = placeDTO.PhoneNumber;
                        controllerContext.dALContext.ContactDAL.AddContact(contact);

                        Place place = new Place();
                        place.ContactId = controllerContext.ContactController.GetLastId();
                        place.PlaceTypeId = controllerContext.PlaceTypeController.GetTypeIdByName(placeDTO.PlaceTypeName);
                        place.DistrictId = controllerContext.DistrictController.GetDistrictIdByName(placeDTO.DistrictName).DistrictId;
                        place.Score = placeDTO.Score;
                        place.Capacity = placeDTO.Capacity;
                        place.TopLeftX = placeDTO.TopLeftX;
                        place.TopLeftY = placeDTO.TopLeftY;
                        place.BottomRightX = placeDTO.BottomRightX;
                        place.BottomRightY = placeDTO.BottomRightY;
                        List<int> listOfError = controllerContext.PlaceController.AddPlace(place);

                        if (listOfError.Count != 0)
                        {
                            string errorMessage = "";
                            foreach (int i in listOfError)
                            {
                                errorMessage = errorMessage + " " + i + ", ";
                            }
                            errorMessage = errorMessage + " have been broken!";
                            byte[] messageByteForm = Encoding.ASCII.GetBytes(errorMessage);
                            handler.Send(messageByteForm);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                        else
                        {
                            string message = "201 Created";
                            byte[] messageByteForm = Encoding.ASCII.GetBytes(message);
                            handler.Send(messageByteForm);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                    }
                    else if(request.message.Equals("/GetDistrictRating<EOF>"))
                    {
                        float rating = controllerContext.DistrictController.ComputeDistrictRating(request.body);
                        byte[] messageByteForm = Encoding.ASCII.GetBytes(rating.ToString());
                        handler.Send(messageByteForm);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                    else if (request.message.Equals("/GetCityCoordinates<EOF>"))
                    {
                        City city = controllerContext.CityController.GetCityByName("Bicaz");
                        var json = JsonConvert.SerializeObject(city);
                        byte[] jsonByteForm = Encoding.ASCII.GetBytes(json);
                        handler.Send(jsonByteForm);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close(); 
                    }
                    else if (request.message.Equals("/GetPlaceByAddress<EOF>"))
                    {
                        string address = request.body;
                        Contact contact = controllerContext.ContactController.GetContactByAddress(address);
                        Place place = controllerContext.PlaceController.GetPlaceByContactId(contact.ContactId);
                        var json = JsonConvert.SerializeObject(place);
                        byte[] jsonByteForm = Encoding.ASCII.GetBytes(json);
                        handler.Send(jsonByteForm);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                    else
                    {
                        Console.WriteLine("Text received : {0}", data);
                        byte[] msg = Encoding.ASCII.GetBytes(data);
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
