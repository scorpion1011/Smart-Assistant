using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAssistant.Models
{
    public partial class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public int Phone { get; set; }

        public ICollection<Shop> shops { get; set; }
        public ICollection<UsersThings> usersthings { get; set; }
    }
}
