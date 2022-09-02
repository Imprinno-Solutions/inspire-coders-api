using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Forums.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Handlers
{
    public class AddForumHandler : IRequestHandler<AddForumCommand, Forum>
	{
		private readonly IForumFakeDataStore _fakeDataStore;
		private readonly ICourseFakeDataStore _courseFakeDataStore;
		private readonly IFacilitatorFakeDataStore _facilitatorFakeDataStore;
		private readonly IMapper _mapper;

		public AddForumHandler(IForumFakeDataStore fakeDataStore, ICourseFakeDataStore courseFakeDataStore, 
			IFacilitatorFakeDataStore facilitatorFakeDataStore, IMapper mapper)
		{
			_fakeDataStore = fakeDataStore;
			_courseFakeDataStore = courseFakeDataStore;
			_facilitatorFakeDataStore = facilitatorFakeDataStore;
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public async Task<Forum> Handle(AddForumCommand request, CancellationToken cancellationToken)
		{
			var Forum = _mapper.Map<Forum>(request.AddForumVm);
			Forum.Course = await _courseFakeDataStore.GetCourseByCode(Forum.CourseCode);
			Forum.Facilitator = await _facilitatorFakeDataStore.GetFacilitatorByCode(Forum.FacilitatorCode);
			await _fakeDataStore.AddForum(Forum);
			return Forum;
		}
	}
}
