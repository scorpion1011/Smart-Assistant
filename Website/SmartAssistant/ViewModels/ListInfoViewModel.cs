using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.ViewModels
{
    public class ListInfoViewModel
    {
        public string userId { get; set; }
        public List<ThingViewModel> things { get; set; }

        public ListInfoViewModel ()
        {
            things = new List<ThingViewModel>();
        }
    }
}
