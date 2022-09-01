using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Courses.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Handlers
{
    public class GetCourseByIdHandler : IRequestHandler<GetCourseByIdQuery, Course>
    {
        private readonly ICourseFakeDataStore _fakeDataStore;
        public GetCourseByIdHandler(ICourseFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<Course> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetCourseById(request.Id);

    }
}
