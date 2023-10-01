using Car.Models;
using Microsoft.EntityFrameworkCore;

namespace Car
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Carsed { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
