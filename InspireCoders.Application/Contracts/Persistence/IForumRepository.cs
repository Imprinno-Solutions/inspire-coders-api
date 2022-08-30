using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.Persistence
{
    public interface IForumRepository : IAsyncRepository<Forum>
    {
        Task<IEnumerable<Forum>> GetForumsByCourseCode(string courseCode);
        Task<IEnumerable<Forum>> GetForumsByFacilitatorCode(string facilitatorCode);
        // Task<IEnumerable<Forum>> GetForumsByStudentCode(string studentCode);
    }
}
