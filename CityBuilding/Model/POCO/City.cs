using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class City
    {

        public City()
        {

        }
        public City(string name, float latitudine, float longitude)
        {
            Name = name;
            Latitude = latitudine;
            Longitude = longitude;
        }

        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public ICollection<District> Districts { get; set; } 
    }
}
