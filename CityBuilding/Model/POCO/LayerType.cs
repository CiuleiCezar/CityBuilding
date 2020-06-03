using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class LayerType
    {
        [Key]
        public int LayerTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Layer> Layers { get; set;}         
    }
}
