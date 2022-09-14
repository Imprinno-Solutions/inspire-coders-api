using AutoMapper;
using InspireCoders.Application.Features.Users.ViewModels;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AddUserVm, User>();
            CreateMap<User, GetUsersVm>();
        }
    }
}
