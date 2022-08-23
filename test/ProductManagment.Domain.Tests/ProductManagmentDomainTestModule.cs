using ProductManagment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductManagment;

[DependsOn(
    typeof(ProductManagmentEntityFrameworkCoreTestModule)
    )]
public class ProductManagmentDomainTestModule : AbpModule
{

}
