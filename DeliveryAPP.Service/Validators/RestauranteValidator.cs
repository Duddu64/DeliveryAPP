using DeliveryAPP.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Service.Validators
{
    public class RestauranteValidator : AbstractValidator<Restaurante>
    {
        public RestauranteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Endereco)
                    .NotEmpty().WithMessage("Por favor informe o endereco.")
                    .NotNull().WithMessage("Por favor informe o endereco.");
            RuleFor(c => c.Cidade)
                    .NotEmpty().WithMessage("Por favor informe a cidade.")
                    .NotNull().WithMessage("Por favor informe a cidade.");
        }
    }
}
