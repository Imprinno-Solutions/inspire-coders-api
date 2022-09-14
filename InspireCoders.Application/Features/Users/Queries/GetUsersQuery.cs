using InspireCoders.Application.Features.Users.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Users.Queries
{
    public record GetUsersQuery() : IRequest<IEnumerable<GetUsersVm>>;
}
