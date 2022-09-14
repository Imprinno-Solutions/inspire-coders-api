using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.FakeDataStores
{
    public interface IUserFakeDataStore
    {
        Task AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> GetUserByUsername(string code);
    }
}
