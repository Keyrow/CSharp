using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_N_Dishes.Models
{
    public class Dishes
    {
        [Key]
        public int Food_ID { get; set; }
        [Required(ErrorMessage = "Food Name Required")]
        public string Food_Name { get; set; }
        [Required(ErrorMessage = "Calories Field Required")]
        public int Calories { get; set; }
        public int Tastiness { get; set; }
        [Required(ErrorMessage = "Description Required")]
        public string Description { get; set; }
        public int Chef_ID { get; set; }
        public Chefs Creator { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}