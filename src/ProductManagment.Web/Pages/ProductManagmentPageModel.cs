using ProductManagment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductManagment.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductManagmentPageModel : AbpPageModel
{
    protected ProductManagmentPageModel()
    {
        LocalizationResourceType = typeof(ProductManagmentResource);
    }
}
