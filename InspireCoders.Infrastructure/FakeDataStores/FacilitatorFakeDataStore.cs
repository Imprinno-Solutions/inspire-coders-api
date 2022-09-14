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
                new Facilitator
                {
                    Id = 1,
                    FirstName = "Anne",
                    LastName = "Jones",
                    Email = "anne.jones@imprinno.com",
                    Username = "anne-jones",
                    CourseCode = "001",
                    Course = new Course
                            {
                                Id = 1,
                                Title = "Test Course 1",
                                Code = "001",
                                Level = "Beginner",
                                Description = "Test Course 1"
                            },
                    Phone = "09098762345",
                    CreatedDate = DateTime.Now
                },

                new Facilitator
                {
                    Id = 2,
                    FirstName = "Brad",
                    LastName = "Thomas",
                    Email = "brad.thomas@imprinno.com",
                    Username = "brad-thomas",
                    CourseCode = "002",
                    Course = new Course
                            {
                                Id = 2,
                                Title = "Test Course 2",
                                Code = "002",
                                Level = "Intermediate",
                                Description = "Test Course 2"
                            },
                    Phone = "09098762346",
                    CreatedDate = DateTime.Now
                },

                new Facilitator
                {
                    Id = 3,
                    FirstName = "Conway",
                    LastName = "White",
                    Email = "conway.white@imprinno.com",
                    Username = "conway-white",
                    CourseCode = "003",
                    Course = new Course
                            {
                                Id = 3,
                                Title = "Test Course 3",
                                Code = "003",
                                Level = "Advance",
                                Description = "Test Course 3"
                            },
                    Phone = "09098762347",
                    CreatedDate = DateTime.Now
                },
            };
        }

        public async Task AddFacilitator(Facilitator facilitator)
        {
            facilitator.Id = _facilitators.Count + 1;
            facilitator.CreatedBy = "admin";
            facilitator.LastModifiedBy = "admin";
            facilitator.CreatedDate = DateTime.Now;
            facilitator.LastModifiedDate = DateTime.Now;
            _facilitators.Add(facilitator);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Facilitator>> GetAllFacilitators() => await Task.FromResult(_facilitators);

        public async Task<Facilitator> GetFacilitatorById(int id) => await Task.FromResult(_facilitators.First(p => p.Id == id));

        public async Task<Facilitator> GetFacilitatorByCode(string code) => await Task.FromResult(_facilitators.Single(p => p.Code == code));
    }
}
