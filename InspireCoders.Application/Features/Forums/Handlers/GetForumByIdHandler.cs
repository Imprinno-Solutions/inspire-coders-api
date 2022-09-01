using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Forums.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Handlers
{
    public class GetForumByIdHandler : IRequestHandler<GetForumByIdQuery, Forum>
    {
        private readonly IForumFakeDataStore _fakeDataStore;
        public GetForumByIdHandler(IForumFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<Forum> Handle(GetForumByIdQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetForumById(request.Id);

    }
}
