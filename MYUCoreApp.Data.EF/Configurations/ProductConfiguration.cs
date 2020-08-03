using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).UseIdentityColumn().IsRequired();
            builder.HasOne<ProductCategory>(c => c.ProductCategory)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
