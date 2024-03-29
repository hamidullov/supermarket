using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Persistence.Repositories
{
    public interface IProductRepository
    {
         Task<IEnumerable<Product>> ListAsync();
    }
}