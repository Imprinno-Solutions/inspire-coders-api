using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Commands
{
    public record AddForumCommand(Forum Forum) : IRequest<Forum>;
}
