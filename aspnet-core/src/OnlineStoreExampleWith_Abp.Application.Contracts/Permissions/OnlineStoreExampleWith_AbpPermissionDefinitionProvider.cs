using OnlineStoreExampleWith_Abp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OnlineStoreExampleWith_Abp.Permissions;

public class OnlineStoreExampleWith_AbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OnlineStoreExampleWith_AbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OnlineStoreExampleWith_AbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OnlineStoreExampleWith_AbpResource>(name);
    }
}
