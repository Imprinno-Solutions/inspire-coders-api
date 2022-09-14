using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireCoders.Infrastructure.FakeDataStores
{
    public class UserFakeDataStore : IUserFakeDataStore
    {
        private static List<User> _Users;

        public UserFakeDataStore()
        {
            _Users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "anne-jones",
                    Firstname = "Anne",
                    Lastname = "Jones",
                    Password = "Password@1",
                    Salt = "salt1",
                    Role = "Admin",
                    CreatedDate = DateTime.Now
                },

                new User
                {
                    Id = 2,
                    Username = "brad-jones",
                    Firstname = "Brad",
                    Lastname = "Jones",
                    Password = "Password@2",
                    Salt = "salt2",
                    Role = "Facilitator",
                    CreatedDate = DateTime.Now
                },

                new User
                {
                    Id = 3,
                    Username = "cindy-jones",
                    Firstname = "Cindy",
                    Lastname = "Jones",
                    Password = "Password@3",
                    Salt = "salt3",
                    Role = "Student",
                    CreatedDate = DateTime.Now
                },
            };
        }

        public async Task AddUser(User User)
        {
            User.Id = _Users.Count + 1;
            User.CreatedBy = "admin";
            User.LastModifiedBy = "admin";
            User.CreatedDate = DateTime.Now;
            User.LastModifiedDate = DateTime.Now;
            _Users.Add(User);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<User>> GetAllUsers() => await Task.FromResult(_Users);

        public async Task<User> GetUserById(int id) => await Task.FromResult(_Users.First(p => p.Id == id));

        public async Task<User> GetUserByUsername(string username) => await Task.FromResult(_Users.Single(p => p.Username == username));
    }
}
