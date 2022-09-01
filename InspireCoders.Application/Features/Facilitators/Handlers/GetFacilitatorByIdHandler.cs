using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Facilitators.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Handlers
{
    public class GetFacilitatorByIdHandler : IRequestHandler<GetFacilitatorByIdQuery, Facilitator>
    {
        private readonly IFacilitatorFakeDataStore _fakeDataStore;
        public GetFacilitatorByIdHandler(IFacilitatorFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<Facilitator> Handle(GetFacilitatorByIdQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetFacilitatorById(request.Id);

    }
}
