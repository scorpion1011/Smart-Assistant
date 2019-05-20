using SmartAssistant.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartAssistant.ViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
        public int Phone { get; set; }
        [RequiredIfNotEmpty]
        public string Password { get; set; }
    }
}