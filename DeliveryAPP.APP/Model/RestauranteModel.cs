using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.APP.Model
{
    public class RestauranteModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public int IdCidade { get; set; }
        public string? Cidade { get; set; }
        
    }
}
