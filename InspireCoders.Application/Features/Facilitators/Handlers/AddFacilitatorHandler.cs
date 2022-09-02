using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Facilitators.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Handlers
{
    public class AddFacilitatorHandler : IRequestHandler<AddFacilitatorCommand, Facilitator>
	{
		private readonly IFacilitatorFakeDataStore _fakeDataStore;
		private readonly ICourseFakeDataStore _courseFakeDataStore;
		private readonly IMapper _mapper;

		public AddFacilitatorHandler(IFacilitatorFakeDataStore fakeDataStore, ICourseFakeDataStore courseFakeDataStore, IMapper mapper)
		{
			_fakeDataStore = fakeDataStore;
			_courseFakeDataStore = courseFakeDataStore;
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public async Task<Facilitator> Handle(AddFacilitatorCommand request, CancellationToken cancellationToken)
		{
			var facilitator = _mapper.Map<Facilitator>(request.AddFacilitatorVm);
			facilitator.Course = await _courseFakeDataStore.GetCourseByCode(facilitator.CourseCode);
			await _fakeDataStore.AddFacilitator(facilitator);
			return facilitator;
		}
	}
}
