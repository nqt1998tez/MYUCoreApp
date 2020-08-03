using Microsoft.EntityFrameworkCore;
using MYUCoreApp.Data.Entities;
using MYUCoreApp.Data.Enums;
using MYUCoreApp.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace MYUCoreApp.Data.EF.Extensions
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region SeedData for AppUser
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                },
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Description = "Customer"
                });
            #endregion
            #region SeedData for AppUser
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active
                });
            #endregion
            #region SeedData for Contact
            modelBuilder.Entity<Contact>().HasData(
                new Contact()
                {
                    Id = CommonConstants.DefaultContactId,
                    Address = "No 36 Lane 133 Nguyen Phong Sac Cau Giay",
                    Email = "pandashop@gmail.com",
                    Name = "Panda Shop",
                    Phone = "0942 324 543",
                    Status = Status.Active,
                    Website = "http://pandashop.com",
                    Lat = 21.0435009,
                    Lng = 105.7894758
                });
            #endregion
            #region SeedData for Function
            modelBuilder.Entity<Function>().HasData(
                new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "System",ParentId = null,SortOrder = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Role",ParentId = "SYSTEM",SortOrder = 1,Status = Status.Active,URL = "/admin/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Function",ParentId = "SYSTEM",SortOrder = 2,Status = Status.Active,URL = "/admin/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "User",ParentId = "SYSTEM",SortOrder =3,Status = Status.Active,URL = "/admin/user/index",IconCss = "fa-home"  },
                    new Function() {Id = "ACTIVITY", Name = "Activity",ParentId = "SYSTEM",SortOrder = 4,Status = Status.Active,URL = "/admin/activity/index",IconCss = "fa-home"  },
                    new Function() {Id = "ERROR", Name = "Error",ParentId = "SYSTEM",SortOrder = 5,Status = Status.Active,URL = "/admin/error/index",IconCss = "fa-home"  },
                    new Function() {Id = "SETTING", Name = "Configuration",ParentId = "SYSTEM",SortOrder = 6,Status = Status.Active,URL = "/admin/setting/index",IconCss = "fa-home"  },
                    new Function() {Id = "PRODUCT",Name = "Product Management",ParentId = null,SortOrder = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Category",ParentId = "PRODUCT",SortOrder =1,Status = Status.Active,URL = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Product",ParentId = "PRODUCT",SortOrder = 2,Status = Status.Active,URL = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "BILL",Name = "Bill",ParentId = "PRODUCT",SortOrder = 3,Status = Status.Active,URL = "/admin/bill/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "CONTENT",Name = "Content",ParentId = null,SortOrder = 3,Status = Status.Active,URL = "/",IconCss = "fa-table"  },
                    new Function() {Id = "BLOG",Name = "Blog",ParentId = "CONTENT",SortOrder = 1,Status = Status.Active,URL = "/admin/blog/index",IconCss = "fa-table"  },
                    new Function() {Id = "PAGE",Name = "Page",ParentId = "CONTENT",SortOrder = 2,Status = Status.Active,URL = "/admin/page/index",IconCss = "fa-table"  },
                    new Function() {Id = "UTILITY",Name = "Utilities",ParentId = null,SortOrder = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortOrder = 1,Status = Status.Active,URL = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Feedback",ParentId = "UTILITY",SortOrder = 2,Status = Status.Active,URL = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ANNOUNCEMENT",Name = "Announcement",ParentId = "UTILITY",SortOrder = 3,Status = Status.Active,URL = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Contact",ParentId = "UTILITY",SortOrder = 4,Status = Status.Active,URL = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Function() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",SortOrder = 5,Status = Status.Active,URL = "/admin/slide/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ADVERTISMENT",Name = "Advertisment",ParentId = "UTILITY",SortOrder = 6,Status = Status.Active,URL = "/admin/advertistment/index",IconCss = "fa-clone"  },
                    new Function() {Id = "REPORT",Name = "Report",ParentId = null,SortOrder = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Revenue report",ParentId = "REPORT",SortOrder = 1,Status = Status.Active,URL = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Visitor Report",ParentId = "REPORT",SortOrder = 2,Status = Status.Active,URL = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "READER",Name = "Reader Report",ParentId = "REPORT",SortOrder = 3,Status = Status.Active,URL = "/admin/report/reader",IconCss = "fa-bar-chart-o"  },
                });
            #endregion
            #region SeedData for Footer
            modelBuilder.Entity<Footer>().HasData(
                new Footer()
                {
                    Id = CommonConstants.DefaultFooterId,
                    Content = "Footer"
                }); ;
            #endregion
            #region SeedData for Color
            modelBuilder.Entity<Color>().HasData(
                new List<Color>()
                {
                    new Color() {Id=1,Name="Black", Code="#000000" },
                    new Color() {Id=2,Name="White", Code="#FFFFFF"},
                    new Color() {Id=3,Name="Red", Code="#ff0000" },
                    new Color() {Id=4,Name="Blue", Code="#1000ff" },
                });
            #endregion
            #region SeedData for AdvertistmentPage
            modelBuilder.Entity<AdvertistmentPage>().HasData(
                new List<AdvertistmentPage>()
                {
                    new AdvertistmentPage()
                    {
                        Id="home",
                        Name="Home"
                    },
                    new AdvertistmentPage()
                    {
                        Id="product-cate",
                        Name="Product category"
                    },
                    new AdvertistmentPage()
                    {
                        Id="product-detail",
                        Name="Product detail"
                    }
                });
            modelBuilder.Entity<AdvertistmentPosition>().HasData(
                new List<AdvertistmentPosition>()
                {
                     new AdvertistmentPosition()
                     {
                         Id="home-left",
                         Name="Bên trái",
                         PageId= "home"
                     },
                     new AdvertistmentPosition()
                     {
                         Id="product-cate-left",
                         Name="Bên trái",
                         PageId="product-cate"
                     },
                     new AdvertistmentPosition()
                     {
                         Id="product-detail-left",
                         Name="Bên trái",
                         PageId= "product-detail"
                     }
                });
            #endregion
            #region SeedData for Slide
            modelBuilder.Entity<Slide>().HasData(
                new List<Slide>()
                {
                    new Slide() {Id=1,Name="Slide 1",Image="/client-side/images/slider/slide-1.jpg",Url="#",DisplayOrder = 0,GroupAlias = "top",Status = true },
                    new Slide() {Id=2,Name="Slide 2",Image="/client-side/images/slider/slide-2.jpg",Url="#",DisplayOrder = 1,GroupAlias = "top",Status = true },
                    new Slide() {Id=3,Name="Slide 3",Image="/client-side/images/slider/slide-3.jpg",Url="#",DisplayOrder = 2,GroupAlias = "top",Status = true },
                    new Slide() {Id=4,Name="Slide 1",Image="/client-side/images/brand1.png",Url="#",DisplayOrder = 1,GroupAlias = "brand",Status = true },
                    new Slide() {Id=5,Name="Slide 2",Image="/client-side/images/brand2.png",Url="#",DisplayOrder = 2,GroupAlias = "brand",Status = true },
                    new Slide() {Id=6,Name="Slide 3",Image="/client-side/images/brand3.png",Url="#",DisplayOrder = 3,GroupAlias = "brand",Status = true },
                    new Slide() {Id=7,Name="Slide 4",Image="/client-side/images/brand4.png",Url="#",DisplayOrder = 4,GroupAlias = "brand",Status = true },
                    new Slide() {Id=8,Name="Slide 5",Image="/client-side/images/brand5.png",Url="#",DisplayOrder = 5,GroupAlias = "brand",Status = true },
                    new Slide() {Id=9,Name="Slide 6",Image="/client-side/images/brand6.png",Url="#",DisplayOrder = 6,GroupAlias = "brand",Status = true },
                    new Slide() {Id=10,Name="Slide 7",Image="/client-side/images/brand7.png",Url="#",DisplayOrder = 7,GroupAlias = "brand",Status = true },
                    new Slide() {Id=11,Name="Slide 8",Image="/client-side/images/brand8.png",Url="#",DisplayOrder = 8,GroupAlias = "brand",Status = true },
                    new Slide() {Id=12,Name="Slide 9",Image="/client-side/images/brand9.png",Url="#",DisplayOrder = 9,GroupAlias = "brand",Status = true },
                    new Slide() {Id=13,Name="Slide 10",Image="/client-side/images/brand10.png",Url="#",DisplayOrder = 10,GroupAlias = "brand",Status = true },
                    new Slide() {Id=14,Name="Slide 11",Image="/client-side/images/brand11.png",Url="#",DisplayOrder = 11,GroupAlias = "brand",Status = true },
                });
            #endregion
            #region SeedData for Size
            modelBuilder.Entity<Size>().HasData(
                new List<Size>()
                {
                    new Size() { Id=1,Name="XXL" },
                    new Size() { Id=2,Name="XL"},
                    new Size() { Id=3,Name="L" },
                    new Size() { Id=4,Name="M" },
                    new Size() { Id=5,Name="S" },
                    new Size() { Id=6,Name="XS" }
                });
            #endregion
            #region SeedData for ProductCategory
            modelBuilder.Entity<ProductCategory>().HasData(
                new List<ProductCategory>()
                {
                    new ProductCategory()
                    {
                        Id=1,
                        Name="Men shirt",
                        SeoAlias="men-shirt",
                        ParentId = null,
                        Status=Status.Active,
                        SortOrder=1 
                    },
                    new ProductCategory()
                    {
                        Id=2,
                        Name="Women shirt",
                        SeoAlias="women-shirt",
                        ParentId = null,
                        Status=Status.Active ,
                        SortOrder=2,
                    },
                    new ProductCategory()
                    {
                        Id=3,
                        Name="Men shoes",
                        SeoAlias="men-shoes",
                        ParentId = null,
                        Status=Status.Active ,
                        SortOrder=3 
                    },
                    new ProductCategory()
                    {
                        Id=4,
                        Name="Woment shoes",
                        SeoAlias="women-shoes",
                        ParentId = null,
                        Status=Status.Active,
                        SortOrder=4 
                    },
                });
            modelBuilder.Entity<Product>().HasData(
                    new Product(){CategoryId=1,Id=1,Name = "Product 1",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-1",Price = 1000,Status = Status.Active,OriginalPrice = 1000},
                    new Product(){CategoryId=1,Id=2,Name = "Product 2",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-2",Price = 1000,Status = Status.Active,OriginalPrice = 1000},
                    new Product(){CategoryId=1,Id=3,Name = "Product 3",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-3",Price = 1000,Status = Status.Active,OriginalPrice = 1000},
                    new Product(){CategoryId=1,Id=4,Name = "Product 4",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-4",Price = 1000,Status = Status.Active,OriginalPrice = 1000},
                    new Product(){CategoryId=1,Id=5,Name = "Product 5",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-5",Price = 1000,Status = Status.Active,OriginalPrice = 1000},
                    new Product() { CategoryId = 2, Id = 6, Name = "Product 6", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-6", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 2, Id = 7, Name = "Product 7", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-7", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 2, Id = 8, Name = "Product 8", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-8", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 2, Id = 9, Name = "Product 9", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-9", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 2, Id = 10, Name = "Product 10", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-10", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 3, Id = 11, Name = "Product 11", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-11", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 3, Id = 12, Name = "Product 12", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-12", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 3, Id = 13, Name = "Product 13", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-13", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 3, Id = 14, Name = "Product 14", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-14", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 3, Id = 15, Name = "Product 15", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-15", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 4, Id = 16, Name = "Product 16", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-16", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 4, Id = 17, Name = "Product 17", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-17", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 4, Id = 18, Name = "Product 18", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-18", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product() { CategoryId = 4, Id = 19, Name = "Product 19", DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-19", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                    new Product(){CategoryId=4,Id=20,Name = "Product 20",DateCreated=DateTime.Now,Image="/client-side/images/products/product-1.jpg",SeoAlias = "san-pham-20",Price = 1000,Status = Status.Active,OriginalPrice = 1000}
                );
            #endregion
            #region SeedData SystemConfig
            modelBuilder.Entity<SystemConfig>().HasData(
                new SystemConfig()
                {
                    Id = "HomeTitle",
                    Name = "Home's title",
                    Value1 = "MYU Shop home",
                    Status = Status.Active
                },
                new SystemConfig()
                {
                    Id = "HomeMetaKeyword",
                    Name = "Home Keyword",
                    Value1 = "shopping, sales",
                    Status = Status.Active
                },
                new SystemConfig()
                {
                    Id = "HomeMetaDescription",
                    Name = "Home Description",
                    Value1 = "Home myu",
                    Status = Status.Active
                });
            #endregion
        }
    }
}
