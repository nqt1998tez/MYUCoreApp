using AutoMapper;
using MYUCoreApp.Aplication.ViewModels.Product;
using MYUCoreApp.Data.Entities;

namespace MYUCoreApp.Aplication.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c=> new ProductCategory());
        }
    }
}
