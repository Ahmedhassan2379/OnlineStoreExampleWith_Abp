using OnlineStoreExampleWith_Abp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OnlineStoreExampleWith_Abp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OnlineStoreExampleWith_AbpController : AbpControllerBase
{
    protected OnlineStoreExampleWith_AbpController()
    {
        LocalizationResource = typeof(OnlineStoreExampleWith_AbpResource);
    }
}
