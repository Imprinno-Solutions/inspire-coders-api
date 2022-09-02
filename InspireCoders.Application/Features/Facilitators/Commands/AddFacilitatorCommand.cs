using InspireCoders.Application.Features.Facilitators.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Commands
{
    public record AddFacilitatorCommand(AddFacilitatorVm AddFacilitatorVm) : IRequest<Facilitator>;
}
