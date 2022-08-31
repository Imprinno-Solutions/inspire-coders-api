using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.FakeDataStores
{
    public interface IProductFakeDataStore
    {
        Task AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
