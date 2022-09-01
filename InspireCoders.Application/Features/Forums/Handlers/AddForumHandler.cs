using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Forums.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Handlers
{
    public class AddForumHandler : IRequestHandler<AddForumCommand, Forum>
	{
		private readonly IForumFakeDataStore _fakeDataStore;

		public AddForumHandler(IForumFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<Forum> Handle(AddForumCommand request, CancellationToken cancellationToken)
		{
			await _fakeDataStore.AddForum(request.Forum);

			return request.Forum;
		}
	}
}
