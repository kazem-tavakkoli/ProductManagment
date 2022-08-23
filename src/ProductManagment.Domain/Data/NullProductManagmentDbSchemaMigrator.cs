using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductManagment.Data;

/* This is used if database provider does't define
 * IProductManagmentDbSchemaMigrator implementation.
 */
public class NullProductManagmentDbSchemaMigrator : IProductManagmentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
