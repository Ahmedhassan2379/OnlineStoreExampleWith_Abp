using Volo.Abp.Settings;

namespace OnlineStoreExampleWith_Abp.Settings;

public class OnlineStoreExampleWith_AbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OnlineStoreExampleWith_AbpSettings.MySetting1));
    }
}
