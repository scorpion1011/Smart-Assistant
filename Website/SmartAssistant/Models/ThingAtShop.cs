using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.Models
{
    public class ThingAtShop
    {
        public int idShop { get; set; }
        public Shop shop { get; set; }
        public int idThing { get; set; }
        public Thing thing { get; set; }
        public int price { get; set; }
    }
}
