using InspireCoders.Application.Features.Users.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Users.Commands
{
    public record AddUserCommand(AddUserVm AddUserVm) : IRequest<User>;
}
