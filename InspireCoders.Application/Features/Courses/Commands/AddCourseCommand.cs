using InspireCoders.Application.Features.Courses.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Courses.Commands
{
    public record AddCourseCommand(AddCourseVm AddCourseVm) : IRequest<Course>;
}
