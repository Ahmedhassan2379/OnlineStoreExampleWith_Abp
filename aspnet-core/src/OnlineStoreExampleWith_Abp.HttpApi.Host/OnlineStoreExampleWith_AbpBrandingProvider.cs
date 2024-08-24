using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OnlineStoreExampleWith_Abp;

[Dependency(ReplaceServices = true)]
public class OnlineStoreExampleWith_AbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OnlineStoreExampleWith_Abp";
}
