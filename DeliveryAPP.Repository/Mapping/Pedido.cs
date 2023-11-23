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
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Cliente);

            builder.Property(prop => prop.Valortotal)
                .IsRequired();

            builder.HasOne(prop => prop.Restaurante) ;
            builder.HasMany(prop => prop.Item);

            builder.Property(prop => prop.Datacompra)
                .IsRequired();

        }
    }
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("ItemPedido");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .IsRequired();

            builder.Property(prop => prop.Valortot)
                .IsRequired();
            
            builder.HasOne(prop => prop.Produto);

            builder.Property(prop => prop.Valoruni)
                .IsRequired();
            
        }
    }
}
