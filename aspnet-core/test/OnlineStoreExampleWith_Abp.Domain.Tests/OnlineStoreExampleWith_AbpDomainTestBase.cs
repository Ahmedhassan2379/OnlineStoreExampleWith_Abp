using Volo.Abp.Modularity;

namespace OnlineStoreExampleWith_Abp;

/* Inherit from this class for your domain layer tests. */
public abstract class OnlineStoreExampleWith_AbpDomainTestBase<TStartupModule> : OnlineStoreExampleWith_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
