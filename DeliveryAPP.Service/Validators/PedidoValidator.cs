using DeliveryAPP.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Service.Validators
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator()
        {
            RuleFor(c => c.Item)
                .NotEmpty().WithMessage("Por favor adicione um ou mais itens para o pedido.")
                .NotNull().WithMessage("Por favor adicione um ou mais itens para o pedido.");
        }
    }
}
