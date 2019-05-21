using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.Models
{
    public class UsersListsThings
    {
        [Key]
        public int idUserThing { get; set; }
        public string name { get; set; }
        public string kind { get; set; }
    }
}
