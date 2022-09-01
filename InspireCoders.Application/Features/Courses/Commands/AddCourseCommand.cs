using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Commands
{
    public record AddCourseCommand(Course Course) : IRequest<Course>;
}
