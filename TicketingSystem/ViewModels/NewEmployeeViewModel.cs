using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.ViewModels
{
    public class NewEmployeeViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailUnique", controller: "Maintenance")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public IFormFile Photo { get; set; }
        public List<string> Roles { get; set; }
    }
}
