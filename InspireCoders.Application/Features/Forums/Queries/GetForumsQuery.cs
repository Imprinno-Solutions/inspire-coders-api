using InspireCoders.Application.Features.Forums.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Queries
{
    public record GetForumsQuery() : IRequest<IEnumerable<GetForumsVm>>;
}
