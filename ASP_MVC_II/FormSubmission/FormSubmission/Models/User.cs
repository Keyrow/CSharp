using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormSubmission.Models
{
    public class User
    {
        [MinLength(4, ErrorMessage = "First name must be at least 4 characters")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        //
        [MinLength(4, ErrorMessage = "Last name must be at least 4 characters")]
        [Required(ErrorMessage = "Enter your last name")]
        public string LastName { get; set; }
        //
        [Range(1, 120, ErrorMessage = "Enter a valid age")]
        public int Age { get; set; }
        //
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; }
        [MinLength(8, ErrorMessage = "password must be at least 8 characters")]
        [Required(ErrorMessage = "Enter a password")]
        public string Password { get; set; }
    }
}