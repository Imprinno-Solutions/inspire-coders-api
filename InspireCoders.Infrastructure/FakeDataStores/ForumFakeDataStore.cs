using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Infrastructure.FakeDataStores
{
    public class ForumFakeDataStore : IForumFakeDataStore
    {
        private static List<Forum> _forums;

        public ForumFakeDataStore()
        {
            _forums = new List<Forum>
            {
                new Forum { Id = 1, Name = "Test Product 1" },
                new Forum { Id = 2, Name = "Test Product 2" },
                new Forum { Id = 3, Name = "Test Product 3" }
            };
        }

        public async Task AddForum(Forum forum)
        {
            _forums.Add(forum);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Forum>> GetAllForums() => await Task.FromResult(_forums);
    }
}
