using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Products.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
