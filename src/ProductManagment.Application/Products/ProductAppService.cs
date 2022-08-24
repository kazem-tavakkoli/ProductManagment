using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using ProductManagment.Categoris;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace ProductManagment.Products;

public class ProductAppService:ProductManagmentAppService,IProductAppService
{
    private readonly IRepository<Product, Guid> _productRepository;
    private readonly IRepository<Category, Guid> _categoryRepository;
    public ProductAppService(IRepository<Product,Guid> productRepository,IRepository<Category,Guid> categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }
    public async Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await _productRepository
            .WithDetailsAsync(x => x.Category);
        queryable = (IQueryable<Product>)DynamicQueryableExtensions.Skip(queryable, input.SkipCount)
            .Take(input.MaxResultCount)
            .OrderBy(input.Sorting ?? nameof(Product.Name));
        var products = await AsyncExecuter.ToListAsync(queryable);
        var count = await _productRepository.GetCountAsync();
        return new PagedResultDto<ProductDto>(count, ObjectMapper.Map<List<Product>, List<ProductDto>>(products)
        );
    }

    public async Task CreateAsync(CreateUpdateProductDto input)
    {
        try
        {
            var product = ObjectMapper.Map<CreateUpdateProductDto, Product>(input);
            await _productRepository.InsertAsync(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
    }

    public async Task<ListResultDto<CategoryLookupDto>> GetCategoriesAsync()
    {
        var categoris = await _categoryRepository.GetListAsync();
        return new ListResultDto<CategoryLookupDto>(
            ObjectMapper.Map<List<Category>, List<CategoryLookupDto>>(categoris));
    }

    public async Task<ProductDto> GetAsync(Guid id)
    {
        var product = await _productRepository.FindAsync(id);
        return ObjectMapper.Map<Product, ProductDto>(product);
    }

    public async Task UpdateAsync(Guid id, CreateUpdateProductDto input)
    {
            var product = await _productRepository.FindAsync(id);
            ObjectMapper.Map(input, product);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _productRepository.DeleteAsync(id);
    }
}

