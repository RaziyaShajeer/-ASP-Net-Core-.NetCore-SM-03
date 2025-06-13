using Microsoft.EntityFrameworkCore;

namespace MVCassessment.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
