using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EzShop_Data.EF
{
    public class EzShopDbContextFactory : IDesignTimeDbContextFactory<EzShopDBContext>
    {
        public EzShopDBContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsetting.json")
                    .Build();
            var connectionString = configuration.GetConnectionString("eShopDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<EzShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EzShopDBContext(optionsBuilder.Options);
        }
    }
}
