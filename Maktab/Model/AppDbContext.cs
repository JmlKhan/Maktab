using Microsoft.EntityFrameworkCore;

namespace Maktab.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {}

        public virtual DbSet<User> Users { get; set; }
    }
}
