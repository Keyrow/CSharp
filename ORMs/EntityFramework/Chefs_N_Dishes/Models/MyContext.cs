using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Chefs_N_Dishes.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dishes> dishes { get; set; }
        public DbSet<Chefs> chefs { get; set; }
    }
}