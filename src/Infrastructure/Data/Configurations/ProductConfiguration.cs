using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(t => t.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(128);
            builder.Property(t=> t.Description).IsRequired().HasMaxLength(512);
            builder.Property(t=> t.ImageUrl).IsRequired().HasMaxLength(1028);
            builder.Property(t => t.Created).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
