using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Courses.Queries;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Handlers
{
    public class GetCoursesHandler : IRequestHandler<GetCoursesQuery, IEnumerable<Course>>
    {
        private readonly ICourseFakeDataStore _fakeDataStore;
        public GetCoursesHandler(ICourseFakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<IEnumerable<Course>> Handle(GetCoursesQuery request,
            CancellationToken cancellationToken) => await _fakeDataStore.GetAllCourses();
    }
}
