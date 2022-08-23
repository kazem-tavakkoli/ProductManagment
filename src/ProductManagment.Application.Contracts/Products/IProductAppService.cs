using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductManagment.Products;

public interface IProductAppService:IApplicationService
{
    Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
}