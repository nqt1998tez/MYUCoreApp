using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class AdvertistmentConfiguration : IEntityTypeConfiguration<Advertistment>
    {
        public void Configure(EntityTypeBuilder<Advertistment> builder)
        {
            builder.ToTable("Advertistments");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Name).HasMaxLength(255);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.Image).HasMaxLength(255);
            builder.Property(c => c.Url).HasMaxLength(255);
            builder.Property(c => c.DateCreated);
            builder.Property(c => c.DateModified);
            builder.Property(c => c.SortOrder);
            builder.HasOne<AdvertistmentPosition>(s => s.AdvertistmentPosition)
                .WithMany(g => g.Advertistments)
                .HasForeignKey(s => s.PositionId);
        }
    }
}
