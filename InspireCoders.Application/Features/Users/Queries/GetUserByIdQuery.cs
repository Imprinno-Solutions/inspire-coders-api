using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Users.Queries
{
    public record GetUserByIdQuery(int Id) : IRequest<User>;
}
