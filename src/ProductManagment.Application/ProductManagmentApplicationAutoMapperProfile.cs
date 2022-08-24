using AutoMapper;
using ProductManagment.Categoris;
using ProductManagment.Products;

namespace ProductManagment;

public class ProductManagmentApplicationAutoMapperProfile : Profile
{
    public ProductManagmentApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<Category, CategoryLookupDto>();
        CreateMap<CreateUpdateProductDto, Product>();

    }
}
