using AutoMapper;
using MYUCoreApp.Aplication.ViewModels.Product;
using MYUCoreApp.Data.Entities;

namespace MYUCoreApp.Aplication.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory,ProductCategoryViewModel>();
        }
    }
}
