using MYUCoreApp.Aplication.ViewModels.Product;
using System.Collections.Generic;

namespace MYUCoreApp.Aplication.Interfaces
{
    public interface IProductCategoryService
    {
        ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryViewModel);
        void Update(ProductCategoryViewModel productCategoryViewModel);
        void Delete(int id);
        List<ProductCategoryViewModel> GetAll();
        List<ProductCategoryViewModel> GetAll(string keyword);
        List<ProductCategoryViewModel> GetAllByParentId(int parentId);
        ProductCategoryViewModel GetById(int id);
        void UpdateParentId(int sourceId,int targetId, Dictionary<int,int>items);
        void ReOrder(int sourceID,int targetId);
        List<ProductCategoryViewModel> GetHomeCategories(int top);
        void Save();
    }

}
