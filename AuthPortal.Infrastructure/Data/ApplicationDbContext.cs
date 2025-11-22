using AuthPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthPortal.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
