using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Facilitators.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Handlers
{
    public class AddFacilitatorHandler : IRequestHandler<AddFacilitatorCommand, Facilitator>
	{
		private readonly IFacilitatorFakeDataStore _fakeDataStore;

		public AddFacilitatorHandler(IFacilitatorFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<Facilitator> Handle(AddFacilitatorCommand request, CancellationToken cancellationToken)
		{
			await _fakeDataStore.AddFacilitator(request.Facilitator);

			return request.Facilitator;
		}
	}
}
