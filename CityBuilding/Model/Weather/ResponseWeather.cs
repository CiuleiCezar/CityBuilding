using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Model.Weather
{
    public class ResponseWeather
    {
        public bool ValidRequest;
        public Coord coord { get; set; }
        public List<Weather> weathers { get; } = new List<Weather>();

        static String apiKey = "0097d747be0d06d67ac925de8c6e5673";
        [HttpPost]
        public List<Weather> getInformations(Coord coordinates)
        {
            HttpWebRequest apiRequest = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?lat=" + coordinates.lon + 
                "&lon=" + coordinates.lat + "&appid=" + apiKey) as HttpWebRequest;

            string apiResponse="";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();             
            }

            var jsonData = JObject.Parse(apiResponse);
            if (jsonData.SelectToken("cod").ToString() == "200")
            {
                ValidRequest = true;
                foreach (JToken weather in jsonData.SelectToken("weather"))
                    weathers.Add(new Weather(weather));
            }
            else
            {
                ValidRequest = false;
            }
            if (ValidRequest)
            {
                return weathers;
            }
            return null;
        }
    }
}
