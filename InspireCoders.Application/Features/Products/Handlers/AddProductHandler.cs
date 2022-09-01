using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Products.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Products.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
	{
		private readonly IProductFakeDataStore _fakeDataStore;

		public AddProductHandler(IProductFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
		{
			await _fakeDataStore.AddProduct(request.Product);

			return request.Product;
		}
	}
}
