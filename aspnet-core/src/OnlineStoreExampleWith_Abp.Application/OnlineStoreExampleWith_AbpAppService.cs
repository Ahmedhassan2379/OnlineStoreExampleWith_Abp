using System;
using System.Collections.Generic;
using System.Text;
using OnlineStoreExampleWith_Abp.Localization;
using Volo.Abp.Application.Services;

namespace OnlineStoreExampleWith_Abp;

/* Inherit your application services from this class.
 */
public abstract class OnlineStoreExampleWith_AbpAppService : ApplicationService
{
    protected OnlineStoreExampleWith_AbpAppService()
    {
        LocalizationResource = typeof(OnlineStoreExampleWith_AbpResource);
    }
}
