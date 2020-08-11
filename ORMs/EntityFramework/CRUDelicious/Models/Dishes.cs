using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dishes
    {
        // auto-implemented properties need to match the columns in your table
        // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
        [Key]
        public int id { get; set; }
        // Validations for Dishes
        [Required(ErrorMessage = "Name of Dish Required")]
        [MinLength(2, ErrorMessage = "Name of dish must be at least 2 characters long")]
        public string Name { get; set; }
        // Validations for Chef's name
        [Required(ErrorMessage = "Please Enter the name of the Chef")]
        [MinLength(2, ErrorMessage = "Chef's name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Chef's name must be letters only")]
        public string Chef { get; set; }
        // Validations for tastiness
        [Required(ErrorMessage = "Please Enter your ratings")]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        // Validations for Calories
        [Required(ErrorMessage = "Please Enter the amount of Calories of the dish 1-2000")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Calories must be in numbers only, no letters")]
        [Range(1, 2000)]
        public int Calories { get; set; }
        // Validations for description
        [Required(ErrorMessage = "Please enter a description of the dish")]
        [MinLength(3, ErrorMessage = "Description must be at least 3 characters long")]
        public string Description { get; set; }
    }
}