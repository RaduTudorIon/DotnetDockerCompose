using Containers.Models;
using Microsoft.EntityFrameworkCore;

namespace Containers.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; } = null!;
    }
}