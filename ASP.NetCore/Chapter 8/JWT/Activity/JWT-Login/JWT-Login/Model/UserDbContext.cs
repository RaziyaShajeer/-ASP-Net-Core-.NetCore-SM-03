using Microsoft.EntityFrameworkCore;

namespace JWT_Login.Model
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
