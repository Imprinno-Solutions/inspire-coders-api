using AutoMapper;
using InspireCoders.Application.Features.Facilitators.ViewModels;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Mappings
{
    public class FacilitatorProfile : Profile
    {
        public FacilitatorProfile()
        {
            CreateMap<AddFacilitatorVm, Facilitator>();
            CreateMap<Facilitator, GetFacilitatorsVm>();
        }
    }
}
