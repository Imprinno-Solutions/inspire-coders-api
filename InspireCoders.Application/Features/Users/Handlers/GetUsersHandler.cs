using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Users.Queries;
using InspireCoders.Application.Features.Users.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Users.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersQuery, IEnumerable<GetUsersVm>>
    {
        private readonly IUserFakeDataStore _fakeDataStore;
        private readonly IMapper _mapper;
        public GetUsersHandler(IUserFakeDataStore fakeDataStore, IMapper mapper)
        {
            _fakeDataStore = fakeDataStore;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<GetUsersVm>> Handle(GetUsersQuery request,
            CancellationToken cancellationToken)
        {
            var Users = await _fakeDataStore.GetAllUsers();
            return _mapper.Map<List<GetUsersVm>>(Users);
        }
    }
}
