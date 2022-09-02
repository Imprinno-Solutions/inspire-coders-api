using AutoMapper;
using InspireCoders.Application.Features.Courses.ViewModels;
using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Mappings
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<AddCourseVm, Course>();
            CreateMap<Course, GetCoursesVm>();
        }
    }
}
