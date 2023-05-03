using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Validations
{
    internal class PersonDTOValidator : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidator() 
        {
            RuleFor(x => x.Document).NotEmpty().NotNull().WithMessage("Documento deve ser informado!");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Nome deve ser informado!");
            RuleFor(x => x.Phone).NotEmpty().NotNull().WithMessage("Telefone deve ser informado!");
        }
    }
}
