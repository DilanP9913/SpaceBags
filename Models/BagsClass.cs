using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Spacebags.Models
{
    public class BagsClass
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string color { get; set; }
     
        [Range(1,5)]
        public double review { get; set; }
    }
}
