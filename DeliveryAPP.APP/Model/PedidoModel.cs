using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.APP.Model
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            Item = new List<ItemPedido>();
        }
        public int Id { get; set; }
        public List<ItemPedido> Item { get; set; }
        public DateTime? Datacompra { get; set; }
        public double Valortotal { get; set; }
        public int IdCliente { get; set; }
        public string? Cliente { get; set; }
        public int IdRestaurante { get; set; }
        public string? Restaurante { get; set; }
    }

    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Valoruni { get; set; }
        public int IdProduto { get; set; }
        public string? Produto { get; set; }
        public double Valortot { get; set; }
    }
}
