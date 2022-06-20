using LeadApi.Application.Queries;
using LeadAPI.Domain.Commands.Lead;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeadAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromBody] GetAllLeadsFilter filter)
        {
            var response = await _mediator.Send(filter);

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateLeadCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
