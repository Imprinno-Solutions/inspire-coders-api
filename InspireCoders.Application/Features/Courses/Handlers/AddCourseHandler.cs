using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Courses.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Handlers
{
    public class AddCourseHandler : IRequestHandler<AddCourseCommand, Course>
	{
		private readonly ICourseFakeDataStore _fakeDataStore;
		private readonly IMapper _mapper;

		public AddCourseHandler(ICourseFakeDataStore fakeDataStore, IMapper mapper)
		{
			_fakeDataStore = fakeDataStore;
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public async Task<Course> Handle(AddCourseCommand request, CancellationToken cancellationToken)
		{
			// _mapper.Map(request, orderToUpdate, typeof(UpdateOrderCommand), typeof(Order));

			var course = _mapper.Map<Course>(request.AddCourseVm);

			await _fakeDataStore.AddCourse(course);

			return course;
		}
	}
}
