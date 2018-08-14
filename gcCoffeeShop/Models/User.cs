using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gcCoffeeShop.Models
{
    public class User
    {
        [Display(Name = "First Name")]
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Password { get; set; }
    }
}