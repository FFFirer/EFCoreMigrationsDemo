using EFCoreMigrationsDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationsDemo.Domain
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
