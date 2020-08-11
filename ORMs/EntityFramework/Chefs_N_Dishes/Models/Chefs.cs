using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_N_Dishes.Models
{
    public class Chefs
    {
        [Key]
        public int Chef_ID { get; set; }
        [Required(ErrorMessage = "First Name Required")]
        public string Chef_FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public string Chef_LastName { get; set; }
        [Required(ErrorMessage = "Age Field Required")]
        [CheckChefAge]
        [Display(Name = "Date of Birth")]
        public DateTime Chef_Age { get; set; }
        public List<Dishes> CreatedDishes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public class CheckChefAge : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                int age = CalculateAge((DateTime)value);
                if (age < 18)
                {
                    return new ValidationResult("Chefs must be at least 18 years old!");
                }
                return ValidationResult.Success;
            }
        }
        public static int CalculateAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}

