using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class PlaceType
    {

        [Key]
        public int PlaceTypeId { get; set; }
        public string placeType { get; set; }
        public ICollection<Place> Place { get; set; }
    }
}
