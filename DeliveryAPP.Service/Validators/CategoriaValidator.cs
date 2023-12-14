using FluentValidation;
using DeliveryAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Service.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor informe o nome.")
               .NotNull().WithMessage("Por favor informe o nome.");
        }
    }
}
