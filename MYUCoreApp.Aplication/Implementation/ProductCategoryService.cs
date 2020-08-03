using AutoMapper;
using AutoMapper.QueryableExtensions;
using MYUCoreApp.Aplication.Interfaces;
using MYUCoreApp.Aplication.ViewModels.Product;
using MYUCoreApp.Data.Entities;
using MYUCoreApp.Data.Enums;
using MYUCoreApp.Data.IRepositories;
using MYUCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MYUCoreApp.Aplication.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository,
                                      IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        Mapper mapper;
        public ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryViewModel)
        {
            var productCategory = mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);
            _productCategoryRepository.Add(productCategory);
            return productCategoryViewModel;
        }

        public void Delete(int id)
        {
            this._productCategoryRepository.Remove(id);
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            return _productCategoryRepository.FindAll().OrderBy(x => x.ParentId)
                    .ProjectTo<ProductCategoryViewModel>(mapper.ConfigurationProvider).ToList();

        }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _productCategoryRepository.FindAll(x => x.Name.Contains(keyword) || x.Description.Contains(keyword))
                    .OrderBy(x => x.ParentId)
                    .ProjectTo<ProductCategoryViewModel>(mapper.ConfigurationProvider)
                    .ToList();
            }
            else
            {
                return _productCategoryRepository.FindAll().OrderBy(x => x.ParentId)
                    .ProjectTo<ProductCategoryViewModel>(mapper.ConfigurationProvider)
                    .ToList();
            }
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            return _productCategoryRepository.FindAll(x => x.Status == Status.Active && x.ParentId == parentId)
                .ProjectTo<ProductCategoryViewModel>(mapper.ConfigurationProvider)
                .ToList();

        }

        public ProductCategoryViewModel GetById(int id)
        {
            return mapper.Map<ProductCategory, ProductCategoryViewModel>(_productCategoryRepository.FindById(id));
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            var query = _productCategoryRepository.FindAll(x => x.HomeFlag == true, c => c.Products)
                                                 .OrderBy(x => x.HomeOrder).Take(top)
                                                 .ProjectTo<ProductCategoryViewModel>(mapper.ConfigurationProvider);
            var categories = query.ToList();
            foreach (var category in categories)
            {
                //category.ProductViewModels
                //    .FindAll(x=>x.HomeFlag == true &&  x.Cate)
            }
            return categories;

        }

        public void ReOrder(int sourceID, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this._unitOfWork.Commit();
        }

        public void Update(ProductCategoryViewModel productCategoryViewModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}

