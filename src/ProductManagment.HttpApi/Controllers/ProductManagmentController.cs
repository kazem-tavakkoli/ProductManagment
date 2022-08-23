using ProductManagment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductManagment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductManagmentController : AbpControllerBase
{
    protected ProductManagmentController()
    {
        LocalizationResource = typeof(ProductManagmentResource);
    }
}
