using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_N_Dishes.Models
{
    public class DishViewModel
    {
        public List<Chefs> allChefs { get; set; }
        public Dishes dish { get; set; }
    }
}