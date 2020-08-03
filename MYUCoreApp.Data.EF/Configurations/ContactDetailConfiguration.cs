﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYUCoreApp.Data.Entities;

namespace MYUCoreApp.Data.EF.Configurations
{
    public class ContactDetailConfiguration : IEntityTypeConfiguration<Contact>
    {
        public  void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}
