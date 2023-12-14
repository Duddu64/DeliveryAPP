using DeliveryAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Repository.Mapping
{
    public class RestauranteMap : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("Restaurante");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Cidade);

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

        }
    }
}
