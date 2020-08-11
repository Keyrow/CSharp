using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogReg.Models
{
    public class Register
    {
        // Validations for first name, must not be empty, min. 2chars, and only letters
        [Required(ErrorMessage = "Enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "first name must be letters only")]
        public string FirstName { get; set; }

        // Validations for last name, must not be empty, min. 2chars, and only letters
        [Required(ErrorMessage = "Enter your Last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must be letters only")]
        public string LastName { get; set; }

        // Validations for email, must not be empty and proper email format
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string RegisterEmail { get; set; }

        // Validations for password, must not be empty, and min. 8chars
        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        public string RegisterPassword { get; set; }

        // Validations for confirm password, checks if it matches with password
        [Compare("RegisterPassword", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}