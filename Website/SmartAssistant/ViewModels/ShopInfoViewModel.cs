using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.ViewModels
{
    public class ShopInfoViewModel
    {
        public string userId { get; set; }
        public List<ShopViewModel> shops { get; set; }

        public ShopInfoViewModel()
        {
            shops = new List<ShopViewModel>();
        }
    }
}
