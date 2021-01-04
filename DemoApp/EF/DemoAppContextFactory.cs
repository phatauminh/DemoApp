using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DemoApp.EF
{
    public class DemoAppContextFactory : IDesignTimeDbContextFactory<DemoAppDbContext>
    {
        public DemoAppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DemoAppDb");

            var optionsBuilder = new DbContextOptionsBuilder<DemoAppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DemoAppDbContext(optionsBuilder.Options);
        }
    }
}
