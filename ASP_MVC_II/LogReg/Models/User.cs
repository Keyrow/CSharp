using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogReg.Models
{
    public class User
    {
        // Validations for email, must not be empty and proper email format
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string LoginEmail { get; set; }
        // Validations for password, must not be empty, and min. 8chars
        [Required(ErrorMessage = "Enter your password")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        public string LoginPassword { get; set; }
    }
}