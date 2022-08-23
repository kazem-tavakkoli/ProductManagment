using System.Threading.Tasks;

namespace ProductManagment.Data;

public interface IProductManagmentDbSchemaMigrator
{
    Task MigrateAsync();
}
