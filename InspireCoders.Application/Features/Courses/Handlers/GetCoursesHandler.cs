using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Courses.Queries;
using InspireCoders.Application.Features.Courses.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Handlers
{
    public class GetCoursesHandler : IRequestHandler<GetCoursesQuery, IEnumerable<GetCoursesVm>>
    {
        private readonly ICourseFakeDataStore _fakeDataStore;
        private readonly IMapper _mapper;
        public GetCoursesHandler(ICourseFakeDataStore fakeDataStore, IMapper mapper) 
        {
            _fakeDataStore = fakeDataStore;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        } 
        public async Task<IEnumerable<GetCoursesVm>> Handle(GetCoursesQuery request,
            CancellationToken cancellationToken)
        {
            var courses = await _fakeDataStore.GetAllCourses();
            return _mapper.Map<List<GetCoursesVm>>(courses);
        } 
    }
}
