using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eHyperStore.Data.EF
{
    public class EHyperDbContextFactory : IDesignTimeDbContextFactory<EHyperDbContext>
    {
        public EHyperDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eHyperStoreDb");

            var optionsBuilder = new DbContextOptionsBuilder<EHyperDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EHyperDbContext(optionsBuilder.Options);
        }
    }
}