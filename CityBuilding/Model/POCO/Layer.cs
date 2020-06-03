using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class Layer
    {
        [Key]
        public int LayerId { get; set; }
        public int LayerTypeId { get; set; }
        public LayerType layerType { get; set; }

    }
}
