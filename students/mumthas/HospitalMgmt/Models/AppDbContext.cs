using Microsoft.EntityFrameworkCore;

namespace HospitalMgmt.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Doctors> Doctors { get; set; } 
        public DbSet<User> Users { get; set; }
    }
}
