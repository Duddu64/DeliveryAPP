using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace DeliveryAPP.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Restaurante>? Restaurante { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Categoria>? Grupo { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
        public DbSet<ItemPedido>? ItemPedido { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Restaurante>(new RestauranteMap().Configure);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Pedido>(new PedidoMap().Configure);
            modelBuilder.Entity<ItemPedido>(new ItemPedidoMap().Configure);
        }
    }
}
