using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Produto : BaseEntity<int> 
    {
        public Produto() { }
        public Produto(int Id, string? nome, Categoria? categoria, Restaurante? restaurante):base(Id)
        {
            Categoria= categoria;
            Nome= nome;
        }
        public string? Nome { get; set; }
        public Categoria? Categoria { get; set;}
        public Restaurante? Restaurante { get; set;}

    }
}
