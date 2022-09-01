using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Facilitators.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Handlers
{
    public class GetFacilitatorsHandler : IRequestHandler<GetFacilitatorsQuery, IEnumerable<Facilitator>>
    {
        private readonly IFacilitatorFakeDataStore _fakeDataStore;
        public GetFacilitatorsHandler(IFacilitatorFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<IEnumerable<Facilitator>> Handle(GetFacilitatorsQuery request,
            CancellationToken cancellationToken) => await _fakeDataStore.GetAllFacilitators();
    }
}
