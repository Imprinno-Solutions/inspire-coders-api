using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
