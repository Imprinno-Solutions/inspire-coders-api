using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Commands
{
    public record AddFacilitatorCommand(Facilitator Facilitator) : IRequest<Facilitator>;
}
