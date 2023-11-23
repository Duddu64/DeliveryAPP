using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAPP.Domain.Base;

namespace DeliveryAPP.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() { }
        public Cliente(int id, string? nome, string? email, string? endereco, Cidade cidade) : base(id)
        {
            Nome= nome;
            Email= email;
            Endereco= endereco;
            Cidade= cidade;
        }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
