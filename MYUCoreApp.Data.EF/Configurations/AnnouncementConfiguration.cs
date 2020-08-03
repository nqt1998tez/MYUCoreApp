using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).HasColumnType("nvarchar(128)");
        }
    }
}
