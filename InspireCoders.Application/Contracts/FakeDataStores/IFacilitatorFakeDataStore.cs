using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.FakeDataStores
{
    public interface IFacilitatorFakeDataStore
    {
        Task AddFacilitator(Facilitator facilitator);
        Task<IEnumerable<Facilitator>> GetAllFacilitators();
    }
}
