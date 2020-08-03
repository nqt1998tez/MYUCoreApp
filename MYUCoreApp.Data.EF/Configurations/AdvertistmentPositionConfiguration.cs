using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MYUCoreApp.Data.Entities;
using static MYUCoreApp.Data.EF.Extensions.ModelBuilderExtensions;
using Microsoft.EntityFrameworkCore;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : IEntityTypeConfiguration<AdvertistmentPosition>
    {
        public void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.HasKey(c=>c.Id);
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            entity.HasMany<Advertistment>(c => c.Advertistments)
                .WithOne(c => c.AdvertistmentPosition)
                .HasForeignKey(c => c.PositionId);
            entity.HasOne<AdvertistmentPage>(c => c.AdvertistmentPage)
                .WithMany(c => c.AdvertistmentPositions)
                .HasForeignKey(c => c.PageId);
        }
    }
}
