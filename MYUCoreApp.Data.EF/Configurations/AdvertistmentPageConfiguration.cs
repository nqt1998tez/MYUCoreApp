using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPageConfiguration : IEntityTypeConfiguration<AdvertistmentPage>
    {
        public void Configure(EntityTypeBuilder<AdvertistmentPage> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).HasColumnType("nvarchar(20)");
            builder.HasMany<AdvertistmentPosition>(c => c.AdvertistmentPositions)
                .WithOne(c => c.AdvertistmentPage)
                .HasForeignKey(c => c.PageId);
        }
    }
}
