using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Restaurante:BaseEntity<int>
    {
        public Restaurante() { }
        public Restaurante(int Id, string? nome, string? endereco, Cidade? cidade, Produto? produto) : base(Id)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
            Produto = produto;
        }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public Cidade? Cidade { get; set; }
        public Produto? Produto { get; set;}
    }
}
