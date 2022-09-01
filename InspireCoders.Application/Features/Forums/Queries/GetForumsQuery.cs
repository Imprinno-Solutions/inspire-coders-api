using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Queries
{
    public record GetForumsQuery() : IRequest<IEnumerable<Forum>>;
}
