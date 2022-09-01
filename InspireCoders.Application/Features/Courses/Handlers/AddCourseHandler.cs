using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Courses.Commands;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Handlers
{
    public class AddCourseHandler : IRequestHandler<AddCourseCommand, Course>
	{
		private readonly ICourseFakeDataStore _fakeDataStore;

		public AddCourseHandler(ICourseFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<Course> Handle(AddCourseCommand request, CancellationToken cancellationToken)
		{
			await _fakeDataStore.AddCourse(request.Course);

			return request.Course;
		}
	}
}
