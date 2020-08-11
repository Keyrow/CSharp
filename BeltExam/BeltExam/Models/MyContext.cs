using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Join> Enthusiasts { get; set; }
    }
}