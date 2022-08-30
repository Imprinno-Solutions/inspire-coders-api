using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.Persistence
{
    public interface ICourseRepository : IAsyncRepository<Course>
    {
        // Task<IEnumerable<Course>> GetOrdersByUserName(string userName);
    }
}
