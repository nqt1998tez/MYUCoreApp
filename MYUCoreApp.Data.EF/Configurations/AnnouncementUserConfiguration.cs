using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class AnnouncementUserConfiguration : IEntityTypeConfiguration<AnnouncementUser>
    {
        public void Configure(EntityTypeBuilder<AnnouncementUser> builder)
        {
            builder.ToTable("AnnouncementUsers");
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.AnnouncementId).HasMaxLength(128).IsRequired();
            builder.Property(c => c.HasRead).HasDefaultValue();

        }
    }
}
