using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Infrastructure.FakeDataStores
{
    public class FacilitatorFakeDataStore : IFacilitatorFakeDataStore
    {
        private static List<Facilitator> _facilitators;

        public FacilitatorFakeDataStore()
        {
            _facilitators = new List<Facilitator>
            {
                new Facilitator { Id = 1, Code = "Test Product 1" },
                new Facilitator { Id = 2, Code = "Test Product 2" },
                new Facilitator { Id = 3, Code = "Test Product 3" }
            };
        }

        public async Task AddFacilitator(Facilitator facilitator)
        {
            _facilitators.Add(facilitator);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Facilitator>> GetAllFacilitators() => await Task.FromResult(_facilitators);

        public async Task<Facilitator> GetFacilitatorById(int id) => await Task.FromResult(_facilitators.Single(p => p.Id == id));
    }
}
