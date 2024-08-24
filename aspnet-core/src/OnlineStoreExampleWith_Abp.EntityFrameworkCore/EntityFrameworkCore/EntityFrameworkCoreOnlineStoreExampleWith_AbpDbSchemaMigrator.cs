using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineStoreExampleWith_Abp.Data;
using Volo.Abp.DependencyInjection;

namespace OnlineStoreExampleWith_Abp.EntityFrameworkCore;

public class EntityFrameworkCoreOnlineStoreExampleWith_AbpDbSchemaMigrator
    : IOnlineStoreExampleWith_AbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOnlineStoreExampleWith_AbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the OnlineStoreExampleWith_AbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OnlineStoreExampleWith_AbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
