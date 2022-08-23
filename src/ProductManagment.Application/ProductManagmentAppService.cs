using System;
using System.Collections.Generic;
using System.Text;
using ProductManagment.Localization;
using Volo.Abp.Application.Services;

namespace ProductManagment;

/* Inherit your application services from this class.
 */
public abstract class ProductManagmentAppService : ApplicationService
{
    protected ProductManagmentAppService()
    {
        LocalizationResource = typeof(ProductManagmentResource);
    }
}
