using InspireCoders.Application.Features.Courses.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Queries
{
    public record GetCoursesQuery() : IRequest<IEnumerable<GetCoursesVm>>;
}
