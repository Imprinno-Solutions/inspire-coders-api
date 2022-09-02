using AutoMapper;
using InspireCoders.Application.Features.Forums.ViewModels;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Mappings
{
    public class ForumProfile : Profile
    {
        public ForumProfile()
        {
            CreateMap<AddForumVm, Forum>();
            CreateMap<Forum, GetForumsVm>();
        }
    }
}
