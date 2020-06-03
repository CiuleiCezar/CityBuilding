using Controller.Controllers;
using Model.DataAccessLayer;
using Model.POCO;
using Model.Weather;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web.Helpers;
using System.Windows.Forms;
using View1;

namespace CityProject
{
    public partial class Form1 : Form
    {
        ControllerContext controllerContext = new ControllerContext();
        Client client = new Client();
        public Form1()
        {
            InitializeComponent();
            PictureBoxMap.MouseDown += new MouseEventHandler(Form1_MouseDown);
            PictureBoxMap.MouseUp += new MouseEventHandler(Form1_MouseUp);
            PictureBoxMap.MouseMove += new MouseEventHandler(Form1_MouseMove);
            PictureBoxMap.Paint += new PaintEventHandler(PictureBox1_Paint);
            client = new Client();
        }

        Rectangle rect;
        Point locationXY;
        Point locationX1Y1;
        Bitmap map = new Bitmap(600, 600);
        bool isMouseDown = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g1 = Graphics.FromImage(map);
            g1.Clear(Color.Green);

            List<Place> listOfPlaces = controllerContext.PlaceController.GetAllPlaces();
            string type;

            foreach (Place place in listOfPlaces)
            {
                type = controllerContext.PlaceTypeController.GetTypeNameById(place.PlaceTypeId);
                int height = place.BottomRightX - place.TopLeftX;
                int width = place.BottomRightY - place.TopLeftY;
                Bitmap imageToDraw;
                switch (type)
                {
                    case "Factory":
                        imageToDraw = new Bitmap(View1.Properties.Resources.Factory, new Size(height, width));
                        break;
                    case "HouseBuilding":
                        imageToDraw = new Bitmap(View1.Properties.Resources.HouseBuilding, new Size(height, width));
                        break;

                    case "Forest":
                        imageToDraw = new Bitmap(View1.Properties.Resources.Forest, new Size(height, width));
                        break;

                    case "Hydro":
                        imageToDraw = new Bitmap(View1.Properties.Resources.Hydro, new Size(height, width));
                        break;
                    case "Park":
                        imageToDraw = new Bitmap(View1.Properties.Resources.Forest, new Size(height, width));
                        break;
                    default:
                        imageToDraw = new Bitmap(View1.Properties.Resources.HouseBuilding, new Size(height, width));
                        break;
                }
                using (Graphics g = Graphics.FromImage(map))
                {
                    g.DrawImage(imageToDraw, new Point(place.TopLeftX, place.TopLeftY));
                }
            }
            PictureBoxMap.Image = map;
        }

        private void AddPlaceButton(object sender, EventArgs e)
        { 
            Place place = new Place();
            Contact contact = new Contact();
            PlaceDTO placeDTO = new PlaceDTO(ComboBoxDistrict.Text, ComboBoxBuildingType.Text, Int32.Parse(TextBoxCapacity.Text), Int32.Parse(TextBoxScore.Text), locationXY.X,
                                 locationXY.Y, locationX1Y1.X, locationX1Y1.Y, TextBoxAddress.Text, TextBoxAddress.Text, TextBoxAddress.Text, TextBoxEmail.Text);
            string message = "/POST/Place" + "<EOF>";
            var body = JsonConvert.SerializeObject(placeDTO);
            Request request = new Request(message, body);
            var requestToSend = JsonConvert.SerializeObject(request);
            string receivedData = client.sendData(requestToSend);
            if (receivedData.Equals("201 Created"))
            {
                MessageBox.Show("Place 201 Created");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            locationXY = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                locationX1Y1 = e.Location;
                isMouseDown = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                locationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, getRect());
        }

        private Rectangle getRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(locationXY.X, locationX1Y1.X);
            rect.Y = Math.Min(locationXY.Y, locationX1Y1.Y);
            rect.Width = Math.Abs(locationX1Y1.X - locationXY.X);
            rect.Height = Math.Abs(locationX1Y1.Y - locationXY.Y);

            return rect;
        }
        private void RulesButton_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void PictureBoxMap_MouseHover(object sender, EventArgs e)
        {
            var pos = PictureBoxMap.PointToClient(Cursor.Position);

            foreach (Place place in controllerContext.PlaceController.GetAllPlaces())
            {
                int height = place.BottomRightY - place.TopLeftY;
                int width = place.BottomRightX - place.TopLeftX;

                if (pos.X > place.TopLeftX && pos.X < place.TopLeftX + width &&
                   pos.Y > place.TopLeftY && pos.Y < place.TopLeftY + height)
                {
                    Contact contact = controllerContext.dALContext.ContactDAL.GetContactById(place.ContactId);
                    Information.Text = "Address:" + contact.Address + "\n Capacitate" + place.Capacity
                                                    + "\nPhone:" + contact.PhoneNumber + "\n  Email:" + contact.Email;

                    MessageBox.Show("Address:" + contact.Address + "\nCapacitate" + place.Capacity
                                                    + " \nPhone:" + contact.PhoneNumber + "\n Email:" + contact.Email);
                }
            }
        }

        
        private void button2_MouseClick(object sender, MouseEventArgs e)
        { 
            District district = new District();
            district.Name = DistrictTextBox.Text;
            district.Rating = 0;
            district.CityId = 1;

            string message = "/POST/District" + "<EOF>";
            var body = JsonConvert.SerializeObject(district);
            Request request = new Request(message, body);
            var requestToSend = JsonConvert.SerializeObject(request);
            string receivedData = client.sendData(requestToSend);

            if(receivedData.Equals("201 Created"))
            {
                ComboBoxDistrict.Items.Add(district.Name);
                MessageBox.Show("District inserted!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ShowDistrictRatings_Click(object sender, EventArgs e)
        {
            string message = "/GetDistricts" + "<EOF>";
            Request request = new Request(message, null);
            var jsonToSend = JsonConvert.SerializeObject(request);
            string receivedData = client.sendData(jsonToSend);
            var json = JsonConvert.DeserializeObject<List<District>>(receivedData);
            string ratingOfDistrict = "";

            foreach (District district in json)
            {
                string messageRequest = "/GetDistrictRating" + "<EOF>";
                request = new Request(messageRequest, district.Name);
                jsonToSend = JsonConvert.SerializeObject(request);
                receivedData = client.sendData(jsonToSend);
                var floatValue = JsonConvert.DeserializeObject<float>(receivedData);
                ratingOfDistrict = ratingOfDistrict + "Rating of " + district.Name + " is " + floatValue + " \n";
            }

            MessageBox.Show(ratingOfDistrict);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "/GetDistricts" + "<EOF>";
            Request request = new Request(message, null);
            var jsonToSend = JsonConvert.SerializeObject(request);
            string receivedData =  client.sendData(jsonToSend);
            var json = JsonConvert.DeserializeObject<List<District>>(receivedData);
            foreach (District district in json)
            {
                Information.Text += district.Name;
            }  
        }

        private void GetWeather_Click(object sender, EventArgs e)
        {
            string message = "/GetCityCoordinates" + "<EOF>";
            Request request = new Request(message, null);
            var jsonToSend = JsonConvert.SerializeObject(request);
            string receivedData = client.sendData(jsonToSend);
            var json = JsonConvert.DeserializeObject<City>(receivedData);

            ResponseWeather responseWeather = new ResponseWeather();
            List<Weather> weathers = responseWeather.getInformations(new Coord(json.Latitude, json.Longitude));
            foreach(Weather weather in weathers)
            {
                Information.Text = "The weather is " + weather.description + " ";
            }
        }

        private void searchPlaceButton_Click(object sender, EventArgs e)
        {
            string address = PlaceAddress.Text;
            string message = "/GetPlaceByAddress" + "<EOF>";
            Request request = new Request(message, address);
            var jsonToSend = JsonConvert.SerializeObject(request);
            string receivedData = client.sendData(jsonToSend);
            var json = JsonConvert.DeserializeObject<Place>(receivedData);
            PlaceInformation.Text = "Score: " + json.Score + " Capacity:" + json.Capacity + " ";
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string rule = ruleToAdd.Text;
            File.WriteAllText("Rule.txt", rule);
        }
    }
}
