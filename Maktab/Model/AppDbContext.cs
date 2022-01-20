using Microsoft.EntityFrameworkCore;

namespace Maktab.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}
