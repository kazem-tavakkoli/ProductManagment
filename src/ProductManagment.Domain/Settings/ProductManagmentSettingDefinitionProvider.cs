using Volo.Abp.Settings;

namespace ProductManagment.Settings;

public class ProductManagmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductManagmentSettings.MySetting1));
    }
}
