using InspireCoders.Application.Contracts.Persistence;
using InspireCoders.Domain.Entities;
using InspireCoders.Infrastructure.Persistence;

namespace InspireCoders.Infrastructure.Repositories
{
    public class FacilitatorRepository : RepositoryBase<Facilitator>, IFacilitatorRepository
    {
        public FacilitatorRepository(InspireCodersContext dbContext) : base(dbContext)
        {
        }
    }
}
