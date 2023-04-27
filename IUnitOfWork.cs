using Infrastructure_Layer.Models;
using Infrastructure_Layer.Repository;

namespace Infrastructure_Layer
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Customer> Customers { get; }

        IBaseRepository<Product> Products { get; }

        IBaseRepository<Cart> Carts { get; }

        void Save();

        IBaseRepository<List<object>> objects { get; }
    }
}
