using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Products.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Products.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductFakeDataStore _fakeDataStore;
        public GetProductsHandler(IProductFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) => await _fakeDataStore.GetAllProducts();
    }
}
