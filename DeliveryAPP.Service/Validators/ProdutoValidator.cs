using DeliveryAPP.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Categoria)
                    .NotEmpty().WithMessage("Por favor informe a categoria do produto.")
                    .NotNull().WithMessage("Por favor informe a categoria do produto.");
            RuleFor(c => c.Restaurante)
                    .NotEmpty().WithMessage("Por favor informe o restaurante.")
                    .NotNull().WithMessage("Por favor informe o restaurante.");
        }
    }
}
