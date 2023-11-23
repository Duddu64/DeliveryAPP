using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade() { }
        public Cidade(int Id, string? nome, string? estado) : base(Id)
        {
            Nome= nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set;}
    }
}
