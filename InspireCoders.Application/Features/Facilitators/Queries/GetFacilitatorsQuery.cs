using InspireCoders.Application.Features.Facilitators.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Queries
{
    public record GetFacilitatorsQuery() : IRequest<IEnumerable<GetFacilitatorsVm>>;
}
