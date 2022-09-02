using InspireCoders.Application.Features.Facilitators.ViewModels;
using InspireCoders.Application.Features.Facilitators.Commands;
using InspireCoders.Application.Features.Facilitators.Queries;
using InspireCoders.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InspireCoders.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FacilitatorsController : ControllerBase
    {

        private readonly ILogger<FacilitatorsController> _logger;
        private readonly IMediator _mediator;

        public FacilitatorsController(ILogger<FacilitatorsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetFacilitators()
        {
            var Facilitators = await _mediator.Send(new GetFacilitatorsQuery());
            return Ok(Facilitators);
        }

        [HttpPost]
        public async Task<ActionResult> AddFacilitator([FromBody] AddFacilitatorVm AddFacilitatorVm)
        {
            var FacilitatorToReturn = await _mediator.Send(new AddFacilitatorCommand(AddFacilitatorVm));
            return CreatedAtRoute("GetFacilitatorById", new { id = FacilitatorToReturn.Id }, FacilitatorToReturn);
        }

        [HttpGet("{id:int}", Name = "GetFacilitatorById")]
        public async Task<ActionResult> GetFacilitatorById(int id)
        {
            var Facilitator = await _mediator.Send(new GetFacilitatorByIdQuery(id));
            return Ok(Facilitator);
        }
    }
}
