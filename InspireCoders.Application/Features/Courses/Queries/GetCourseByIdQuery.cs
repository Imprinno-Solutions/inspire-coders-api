using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Queries
{
    public record GetCourseByIdQuery(int Id) : IRequest<Course>;
}
