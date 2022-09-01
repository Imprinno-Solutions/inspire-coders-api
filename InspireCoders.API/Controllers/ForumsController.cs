using InspireCoders.Application.Features.Forums.Commands;
using InspireCoders.Application.Features.Forums.Queries;
using InspireCoders.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InspireCoders.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ForumsController : ControllerBase
    {

        private readonly ILogger<ForumsController> _logger;
        private readonly IMediator _mediator;

        public ForumsController(ILogger<ForumsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetForums()
        {
            var Forums = await _mediator.Send(new GetForumsQuery());
            return Ok(Forums);
        }

        [HttpPost]
        public async Task<ActionResult> AddForum([FromBody] Forum Forum)
        {
            var ForumToReturn = await _mediator.Send(new AddForumCommand(Forum));
            return CreatedAtRoute("GetForumById", new { id = ForumToReturn.Id }, ForumToReturn);
        }

        [HttpGet("{id:int}", Name = "GetForumById")]
        public async Task<ActionResult> GetForumById(int id)
        {
            var Forum = await _mediator.Send(new GetForumByIdQuery(id));
            return Ok(Forum);
        }
    }
}
