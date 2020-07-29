using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MYUCoreApp.Data.Entities;
using static MYUCoreApp.Data.EF.Extensions.ModelBuilderExtensions;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class SystemConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c=>c.Id).HasMaxLength(255).IsRequired();
        }
    }
}
