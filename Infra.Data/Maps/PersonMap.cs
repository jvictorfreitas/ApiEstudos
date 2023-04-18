using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("PessoaId").UseIdentityColumn();
            builder.Property(x => x.Id).HasColumnName("Documento");
            builder.Property(x => x.Id).HasColumnName("Nome");
            builder.Property(x => x.Id).HasColumnName("Celular");

            builder.HasMany(x => x.Purchases).WithOne(y => y.Person).HasForeignKey(x => x.PersonId);
        }
    }
}
