using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasMany<Product>(c => c.Products)
                .WithOne(c => c.ProductCategory)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
