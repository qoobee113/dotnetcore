using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.EF
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuaration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                                          .AddJsonFile("appsettings.json")
                                                                          .Build();

            var connectString = configuaration.GetConnectionString("WebAppDb");
            
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
