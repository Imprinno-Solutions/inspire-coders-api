using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Infrastructure.FakeDataStores
{
    public class CourseFakeDataStore : ICourseFakeDataStore
    {
        private static List<Course> _courses;

        public CourseFakeDataStore()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, Title = "Test Product 1" },
                new Course { Id = 2, Title = "Test Product 2" },
                new Course { Id = 3, Title = "Test Product 3" }
            };
        }

        public async Task AddCourse(Course course)
        {
            _courses.Add(course);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Course>> GetAllCourses() => await Task.FromResult(_courses);
    }
}
