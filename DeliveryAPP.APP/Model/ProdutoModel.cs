using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.APP.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? IdCategoria { get; set; }
        public string? Categoria { get; set; }
        public byte[]? Foto { get; set; }
        public int? IdRestaurante { get; set; }
        public string? Restaurante { get; set; }

    }
}
