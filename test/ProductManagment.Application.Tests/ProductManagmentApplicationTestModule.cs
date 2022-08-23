using Volo.Abp.Modularity;

namespace ProductManagment;

[DependsOn(
    typeof(ProductManagmentApplicationModule),
    typeof(ProductManagmentDomainTestModule)
    )]
public class ProductManagmentApplicationTestModule : AbpModule
{

}
