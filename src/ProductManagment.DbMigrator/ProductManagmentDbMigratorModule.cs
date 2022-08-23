using ProductManagment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProductManagment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductManagmentEntityFrameworkCoreModule),
    typeof(ProductManagmentApplicationContractsModule)
    )]
public class ProductManagmentDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
