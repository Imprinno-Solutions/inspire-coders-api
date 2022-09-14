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
                new Forum
                {
                    Id = 1,
                    Name = "UI Design",
                    NumberofStudents = 5,
                    MaximumForumSize = 5,
                    CourseCode = "001",
                    Course = new Course
                            {
                                Id = 1,
                                Title = "Test Course 1",
                                Code = "001",
                                Level = "Beginner",
                                Description = "Test Course 1"
                            },
                    FacilitatorCode = "001",
                    Facilitator = new Facilitator
                            {
                                Id = 1,
                                FirstName = "Anne",
                                LastName = "Jones",
                                Email = "anne.jones@imprinno.com",
                                Username = "anne-jones",
                                Course = new Course
                                        {
                                            Id = 1,
                                            Title = "Test Course 1",
                                            Code = "001",
                                            Level = "Beginner",
                                            Description = "Test Course 1"
                                        },
                                Phone = "09098762345"
                            },
                    StartDate = new DateTime(2022,10,16),
                    CreatedDate = DateTime.Now
                },

                new Forum
                {
                    Id = 2,
                    Name = "Web Development",
                    NumberofStudents = 5,
                    MaximumForumSize = 5,
                    CourseCode = "002",
                    Course = new Course
                            {
                                Id = 2,
                                Title = "Test Course 2",
                                Code = "002",
                                Level = "Intermediate",
                                Description = "Test Course 2"
                            },
                    FacilitatorCode = "002",
                    Facilitator = new Facilitator
                            {
                                Id = 2,
                                FirstName = "Brad",
                                LastName = "Thomas",
                                Email = "brad.thomas@imprinno.com",
                                Username = "brad-thomas",
                                Course = new Course
                                        {
                                            Id = 2,
                                            Title = "Test Course 2",
                                            Code = "002",
                                            Level = "Intermediate",
                                            Description = "Test Course 2"
                                        },
                                Phone = "09098762346"
                            },
                    StartDate = new DateTime(2022,10,16),
                    CreatedDate = DateTime.Now
                },

                new Forum
                {
                    Id = 3,
                    Name = "Frontend Development",
                    NumberofStudents = 5,
                    MaximumForumSize = 5,
                    CourseCode = "003",
                    Course = new Course
                            {
                                Id = 3,
                                Title = "Test Course 3",
                                Code = "003",
                                Level = "Advance",
                                Description = "Test Course 3"
                            },
                    FacilitatorCode = "003",
                    Facilitator = new Facilitator
                            {
                                Id = 3,
                                FirstName = "Conway",
                                LastName = "White",
                                Email = "conway.white@imprinno.com",
                                Username = "conway-white",
                                Course = new Course
                                        {
                                            Id = 3,
                                            Title = "Test Course 3",
                                            Code = "003",
                                            Level = "Advance",
                                            Description = "Test Course 3"
                                        },
                                Phone = "09098762347"
                            },
                    StartDate = new DateTime(2022,10,16),
                    CreatedDate = DateTime.Now
                },
            };
        }

        public async Task AddForum(Forum forum)
        {
            forum.Id = _forums.Count + 1;
            forum.CreatedBy = "admin";
            forum.LastModifiedBy = "admin";
            forum.CreatedDate = DateTime.Now;
            forum.LastModifiedDate = DateTime.Now;
            _forums.Add(forum);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Forum>> GetAllForums() => await Task.FromResult(_forums);

        public async Task<Forum> GetForumById(int id) => await Task.FromResult(_forums.First(p => p.Id == id));
    }
}
