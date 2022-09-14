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
                new Course 
                { 
                    Id = 1, 
                    Title = "Test Course 1",
                    Code = "001",
                    Level = "Beginner",
                    Description = "Test Course 1",
                    CreatedDate = DateTime.Now
                },

                new Course
                {
                    Id = 2,
                    Title = "Test Course 2",
                    Code = "002",
                    Level = "Intermediate",
                    Description = "Test Course 2",
                    CreatedDate = DateTime.Now
                },

                new Course
                {
                    Id = 3,
                    Title = "Test Course 3",
                    Code = "003",
                    Level = "Advance",
                    Description = "Test Course 3",
                    CreatedDate = DateTime.Now
                },
            };
        }

        public async Task AddCourse(Course course)
        {
            course.Id = _courses.Count + 1;
            course.CreatedBy = "admin";
            course.LastModifiedBy = "admin";
            course.CreatedDate = DateTime.Now;
            course.LastModifiedDate = DateTime.Now;
            _courses.Add(course);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Course>> GetAllCourses() => await Task.FromResult(_courses);

        public async Task<Course> GetCourseById(int id) => await Task.FromResult(_courses.First(p => p.Id == id));

        public async Task<Course> GetCourseByCode(string code) => await Task.FromResult(_courses.Single(p => p.Code == code));
    }
}
