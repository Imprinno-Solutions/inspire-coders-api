using InspireCoders.Application.Contracts.Persistence;
using InspireCoders.Domain.Entities;
using InspireCoders.Infrastructure.Persistence;

namespace InspireCoders.Infrastructure.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(InspireCodersContext dbContext) : base(dbContext)
        {
        }
    }
}
