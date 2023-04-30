using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ProdutoId").UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnName("Nome");
            builder.Property(x => x.Coderp).HasColumnName("Coderp");
            builder.Property(x => x.Price).HasColumnName("Price");

            builder.HasMany(x => x.Purchases).WithOne(p => p.Product).HasForeignKey(x => x.ProductId);
        }
    }
}
