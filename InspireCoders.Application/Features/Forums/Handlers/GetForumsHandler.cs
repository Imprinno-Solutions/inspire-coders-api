using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Forums.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Handlers
{
    public class GetForumsHandler : IRequestHandler<GetForumsQuery, IEnumerable<Forum>>
    {
        private readonly IForumFakeDataStore _fakeDataStore;
        public GetForumsHandler(IForumFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<IEnumerable<Forum>> Handle(GetForumsQuery request,
            CancellationToken cancellationToken) => await _fakeDataStore.GetAllForums();
    }
}
