using Microsoft.EntityFrameworkCore;

namespace Wedding_Planner.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) {}
        public DbSet<User> Users { get; set; } 
        public DbSet<Wedding> Weddings { get; set; } 
        public DbSet<Invite> Invites { get; set; } 
    }
}