using InspireCoders.Application.Contracts.Persistence;
using InspireCoders.Domain.Entities;
using InspireCoders.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace InspireCoders.Infrastructure.Repositories
{
    public class ForumRepository : RepositoryBase<Forum>, IForumRepository
    {
        public ForumRepository(InspireCodersContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Forum>> GetForumsByCourseCode(string courseCode)
        {
            var orderList = await _dbContext.Forums
                                    .Where(o => o.Course.Code == courseCode)
                                    .ToListAsync();
            return orderList;
        }

        public async Task<IEnumerable<Forum>> GetForumsByFacilitatorCode(string facilitatorCode)
        {
            var orderList = await _dbContext.Forums
                                    .Where(o => o.Facilitator.Code == facilitatorCode)
                                    .ToListAsync();
            return orderList;
        }

        //public async Task<IEnumerable<Forum>> GetForumsByStudentCode(string studentCode)
        //{
        //    var orderList = await _dbContext.Forums
        //                            .Where(o => o.UserName == userName)
        //                            .ToListAsync();
        //    return orderList;
        //}
    }
}
