using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Users.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Users.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserFakeDataStore _fakeDataStore;
        public GetUserByIdHandler(IUserFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetUserById(request.Id);

    }
}
