using InspireCoders.Application.Features.Courses.Commands;
using InspireCoders.Application.Features.Courses.Queries;
using InspireCoders.Application.Features.Courses.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InspireCoders.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        private readonly ILogger<CoursesController> _logger;
        private readonly IMediator _mediator;

        public CoursesController(ILogger<CoursesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetCourses()
        {
            var Courses = await _mediator.Send(new GetCoursesQuery());
            return Ok(Courses);
        }

        [HttpPost]
        public async Task<ActionResult> AddCourse([FromBody] AddCourseVm AddCourseVm)
        {
            var CourseToReturn = await _mediator.Send(new AddCourseCommand(AddCourseVm));
            return CreatedAtRoute("GetCourseById", new { id = CourseToReturn.Id }, CourseToReturn);
        }

        [HttpGet("{id:int}", Name = "GetCourseById")]
        public async Task<ActionResult> GetCourseById(int id)
        {
            var Course = await _mediator.Send(new GetCourseByIdQuery(id));
            return Ok(Course);
        }
    }
}
