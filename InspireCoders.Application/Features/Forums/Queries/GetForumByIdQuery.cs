using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Queries
{
    public record GetForumByIdQuery(int Id) : IRequest<Forum>;
}
