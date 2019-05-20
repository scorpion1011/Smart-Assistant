using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.ViewModels
{
    public class ShopThingsViewModel
    {
        public int idShop { get; set; }
        public List<ThingViewModel> things { get; set; }

        public ShopThingsViewModel()
        {
            things = new List<ThingViewModel>();
        }
    }
}
