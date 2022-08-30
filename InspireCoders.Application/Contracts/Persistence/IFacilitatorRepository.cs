using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.Persistence
{
    public interface IFacilitatorRepository : IAsyncRepository<Facilitator>
    {
        // Task<IEnumerable<Facilitator>> GetOrdersByUserName(string userName);
    }
}
