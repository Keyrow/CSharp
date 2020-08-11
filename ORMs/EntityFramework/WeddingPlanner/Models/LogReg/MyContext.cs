using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Register> user { get; set; }
    }
}