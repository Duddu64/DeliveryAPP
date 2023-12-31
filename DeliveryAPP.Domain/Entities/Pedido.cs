﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Pedido:BaseEntity<int>
    {
        public Pedido()
        {
            Item = new List<ItemPedido>();
        }
        public Pedido(int Id, DateTime? dataCompra, double valortotal, List<ItemPedido> items, Cliente? cliente, Restaurante? restaurante ) : base(Id)
        {
            Item = items;
            Datacompra = dataCompra;
            Valortotal = valortotal;
            Cliente = cliente;
            Restaurante = restaurante;
        }

        public List<ItemPedido> Item { get; set; }
        public DateTime? Datacompra { get; set; }
        public double Valortotal { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Restaurante? Restaurante { get; set; }

    }
    public class ItemPedido : BaseEntity<int>
    {
        public ItemPedido() { }
        public ItemPedido(int Id, int quantidade, double valoruni, Produto? produto, double valortot, Pedido? pedido) : base(Id)
        {
            Quantidade = quantidade;
            Valoruni = valoruni;
            Valortot = valortot;
            Produto = produto;
            Pedido= pedido;
        }
        public int Quantidade { get; set; }
        public double Valoruni { get; set; }
        public virtual Produto? Produto { get; set; }
        public virtual Pedido? Pedido { get; set; }
        public double Valortot { get; set; }
    }
}
