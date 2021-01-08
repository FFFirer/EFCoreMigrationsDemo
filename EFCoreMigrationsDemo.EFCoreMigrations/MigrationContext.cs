using EFCoreMigrationsDemo.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationsDemo.EFCoreMigrations
{
    public class MigrationContext : DemoContext
    {
        public MigrationContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }
    }
}
