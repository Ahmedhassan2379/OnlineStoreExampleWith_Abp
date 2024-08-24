using Volo.Abp.Modularity;

namespace OnlineStoreExampleWith_Abp;

[DependsOn(
    typeof(OnlineStoreExampleWith_AbpApplicationModule),
    typeof(OnlineStoreExampleWith_AbpDomainTestModule)
)]
public class OnlineStoreExampleWith_AbpApplicationTestModule : AbpModule
{

}
