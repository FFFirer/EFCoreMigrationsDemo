using EFCoreMigrationsDemo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreMigrationsDemo.EFCoreMigrations
{
    public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationContext>
    {
        public MigrationContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoContext>()
                .UseSqlServer("Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=");

            return new MigrationContext(builder.Options);
        }
    }
}
