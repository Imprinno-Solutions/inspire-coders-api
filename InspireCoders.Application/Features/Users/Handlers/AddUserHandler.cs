using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Users.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Users.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, User>
	{
		private readonly IUserFakeDataStore _fakeDataStore;
		private readonly IMapper _mapper;

		public AddUserHandler(IUserFakeDataStore fakeDataStore, IMapper mapper)
		{
			_fakeDataStore = fakeDataStore;
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
		{
			var User = _mapper.Map<User>(request.AddUserVm);
			await _fakeDataStore.AddUser(User);
			return User;
		}
	}
}
