using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class Purchase
    {   
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }


        public Purchase(int productId, int personId, DateTime date) 
        {
            Validations(productId, personId, date);
        }

        public Purchase(int id, int productId, int personId, DateTime date)
        {
            DomainValidationException.When(id > 0, "Id precisa ser informado");
            Id = id;
            Validations(productId, personId, date);
        }

        private void Validations(int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(productId > 0, "Id Produto precisa ser informado");
            DomainValidationException.When(personId > 0, "Id Pessoa precisa ser informada");
            DomainValidationException.When(!date.HasValue, "Data precisa ser informado");

            ProductId = productId;
            PersonId = personId;
            Date = date.Value;

            
        }
    }
}
