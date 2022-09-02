using InspireCoders.Application.Features.Forums.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Commands
{
    public record AddForumCommand(AddForumVm AddForumVm) : IRequest<Forum>;
}
