using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Queries
{
    public record GetFacilitatorsQuery() : IRequest<IEnumerable<Facilitator>>;
}
