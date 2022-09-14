using InspireCoders.Application.Features.Users.Commands;
using InspireCoders.Application.Features.Users.Queries;
using InspireCoders.Application.Features.Users.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InspireCoders.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;
        private readonly IMediator _mediator;

        public UsersController(ILogger<UsersController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var Users = await _mediator.Send(new GetUsersQuery());
            return Ok(Users);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] AddUserVm AddUserVm)
        {
            var UserToReturn = await _mediator.Send(new AddUserCommand(AddUserVm));
            return CreatedAtRoute("GetUserById", new { id = UserToReturn.Id }, UserToReturn);
        }

        [HttpGet("{id:int}", Name = "GetUserById")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var User = await _mediator.Send(new GetUserByIdQuery(id));
            return Ok(User);
        }
    }
}
