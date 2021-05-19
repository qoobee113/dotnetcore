using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuarations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x => new {x.CategoryId, x.ProductId });

            builder.HasOne(x => x.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
