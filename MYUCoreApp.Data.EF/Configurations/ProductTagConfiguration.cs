using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MYUCoreApp.Data.Entities;
using static MYUCoreApp.Data.EF.Extensions.ModelBuilderExtensions;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
        }
    }
}
