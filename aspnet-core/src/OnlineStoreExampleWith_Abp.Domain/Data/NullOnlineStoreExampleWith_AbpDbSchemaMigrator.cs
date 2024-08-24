using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OnlineStoreExampleWith_Abp.Data;

/* This is used if database provider does't define
 * IOnlineStoreExampleWith_AbpDbSchemaMigrator implementation.
 */
public class NullOnlineStoreExampleWith_AbpDbSchemaMigrator : IOnlineStoreExampleWith_AbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
