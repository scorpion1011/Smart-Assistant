using SmartAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.ViewModels
{
    public class ShopViewModel
    {
        public int idShop { get; set; }
        public string name { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int area { get; set; }
        public ICollection<ThingAtShop> thingsAtShop { get; set; }
    }
}
