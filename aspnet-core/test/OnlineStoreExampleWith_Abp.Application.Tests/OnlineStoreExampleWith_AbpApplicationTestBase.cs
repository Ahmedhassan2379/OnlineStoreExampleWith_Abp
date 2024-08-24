using Volo.Abp.Modularity;

namespace OnlineStoreExampleWith_Abp;

public abstract class OnlineStoreExampleWith_AbpApplicationTestBase<TStartupModule> : OnlineStoreExampleWith_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
