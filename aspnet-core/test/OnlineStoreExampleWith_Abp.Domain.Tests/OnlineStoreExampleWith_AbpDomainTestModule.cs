using Volo.Abp.Modularity;

namespace OnlineStoreExampleWith_Abp;

[DependsOn(
    typeof(OnlineStoreExampleWith_AbpDomainModule),
    typeof(OnlineStoreExampleWith_AbpTestBaseModule)
)]
public class OnlineStoreExampleWith_AbpDomainTestModule : AbpModule
{

}
