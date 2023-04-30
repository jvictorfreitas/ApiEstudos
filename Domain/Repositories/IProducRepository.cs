using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProducRepository
    {
        Task<Product> GetProductByIdAsync (int id);
        Task<ICollection<Product>> GetProductsByIdAsync();
        Task<Product> CreateAsync (Product product);
        Task EtidyAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
