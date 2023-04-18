using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> purchases { get; private set; }

        public Product(string name, string codErp, decimal price) 
        {
            Validations(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(id<0, "Id do produto deve ser informado");
            Id = id;
            Validations(name, codErp, price);
        }

        private void Validations(string name, string codErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome do Produto precisa ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "CodicoErp precisa ser informado");
            DomainValidationException.When((price < 0), "Preço do Produto precisa ser informado");

            Name = name;
            CodErp = codErp;
            Price = price;
        }

    }
}
