using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OnlineStoreExampleWith_Abp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class OnlineStoreExampleWith_AbpDbContextFactory : IDesignTimeDbContextFactory<OnlineStoreExampleWith_AbpDbContext>
{
    public OnlineStoreExampleWith_AbpDbContext CreateDbContext(string[] args)
    {
        OnlineStoreExampleWith_AbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<OnlineStoreExampleWith_AbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new OnlineStoreExampleWith_AbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OnlineStoreExampleWith_Abp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
