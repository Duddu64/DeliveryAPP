using FluentValidation;
using DeliveryAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAPP.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");
            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe um endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Por favor informe uma cidade.")
                .NotNull().WithMessage("Por favor informe uma cidade.");
        }
    }
}
