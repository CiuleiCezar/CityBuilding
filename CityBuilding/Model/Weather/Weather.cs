using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weather
{
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

        public Weather()
        {

        }

        public Weather(JToken weatherData)
        {
            if (weatherData is null)
                throw new System.ArgumentNullException(nameof(weatherData));
            id = int.Parse(weatherData.SelectToken("id").ToString(), CultureInfo.InvariantCulture);
            main = weatherData.SelectToken("main").ToString();
            description = weatherData.SelectToken("description").ToString();
            icon = weatherData.SelectToken("icon").ToString();
        }
    }
}
