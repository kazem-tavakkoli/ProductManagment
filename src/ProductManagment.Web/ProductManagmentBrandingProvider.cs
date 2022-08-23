using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProductManagment.Web;

[Dependency(ReplaceServices = true)]
public class ProductManagmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductManagment";
}
