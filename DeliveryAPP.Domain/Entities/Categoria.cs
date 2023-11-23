using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Categoria: BaseEntity<int>
    {
        public Categoria() { }
        
        public Categoria(int Id, string? nome) : base(Id)
        {
            Nome = nome;
        }

        public string? Nome { get; set; }
    }
}
