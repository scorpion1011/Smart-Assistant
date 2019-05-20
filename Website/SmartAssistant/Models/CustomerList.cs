using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.Models
{
    public class CustomerList
    {
        [Key]
        public int idList { get; set; }
        public string idUser { get; set; }
        public ICollection<Thing> things { get; set; }
    }
}
