using Car.Models;
using Microsoft.EntityFrameworkCore;

namespace Car
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }

        public DbSet<Users> Users { get; set; }

    }
}
