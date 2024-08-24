using OnlineStoreExampleWith_Abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OnlineStoreExampleWith_Abp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OnlineStoreExampleWith_AbpEntityFrameworkCoreModule),
    typeof(OnlineStoreExampleWith_AbpApplicationContractsModule)
    )]
public class OnlineStoreExampleWith_AbpDbMigratorModule : AbpModule
{
}
