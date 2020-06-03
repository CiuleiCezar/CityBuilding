using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Model.Weather
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
        public Coord(double lon, double lat)
        {
            this.lon = lon;
            this.lat = lat;
        }
    }
}
