using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Infrastructure.FakeDataStores
{
    public class ProductFakeDataStore : IProductFakeDataStore
    {
        private static List<Product> _products;

        public ProductFakeDataStore()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Test Product 1" },
                new Product { Id = 2, Name = "Test Product 2" },
                new Product { Id = 3, Name = "Test Product 3" }
            };
        }

        public async Task AddProduct(Product product)
        {
            //product.CreatedBy = "admin";
            //product.LastModifiedBy = "admin";
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetProductById(int id) => await Task.FromResult(_products.First(p => p.Id == id));
    }
}
