using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.FakeDataStores
{
    public interface IForumFakeDataStore
    {
        Task AddForum(Forum forum);
        Task<IEnumerable<Forum>> GetAllForums();
    }
}
