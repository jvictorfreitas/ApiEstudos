using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("Compra");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("CompraId").UseIdentityColumn();
            builder.Property(x => x.Id).HasColumnName("PessoaId");
            builder.Property(x => x.Id).HasColumnName("ProdutoId");
            builder.Property(x => x.Id).HasColumnName("DataCompra");

            builder.HasOne(x => x.Person).WithMany(x => x.Purchases);
            builder.HasOne(x => x.Product).WithMany(x => x.Purchases);
        }
    }
}
