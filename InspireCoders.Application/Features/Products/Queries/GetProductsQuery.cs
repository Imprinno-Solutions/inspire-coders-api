using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Products.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
