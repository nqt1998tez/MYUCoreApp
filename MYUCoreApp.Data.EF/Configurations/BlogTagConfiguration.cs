using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MYUCoreApp.Data.Entities;
using static MYUCoreApp.Data.EF.Extensions.ModelBuilderExtensions;
using Microsoft.EntityFrameworkCore;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class BlogTagConfiguration : IEntityTypeConfiguration<BlogTag>
    {
        public  void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .IsUnicode(false).HasMaxLength(50);
        }
    }
}
