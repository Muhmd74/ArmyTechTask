using ArmyTechTask.API.Commons;
using ArmyTechTask.Application.Branches.Queries;
using ArmyTechTask.Application.Cashiers.Commands;
using ArmyTechTask.Application.Cashiers.DTOs;
using ArmyTechTask.Application.Cashiers.Queries;
using ArmyTechTask.Application.Commons.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArmyTechTask.API.Controllers
{
    public class CashiersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CashiersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet(ApiRoutes.Cashiers.GetAll)]
        public async Task<ActionResult<List<CashierListResultDto>>> Get()
        {
            var result = await _mediator.Send(new GetCashiersQuery());

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet(ApiRoutes.Cashiers.Get)]
        public async Task<ActionResult<List<CashierDetailsResultDto>>> GetById(int id)
        {
            var result = await _mediator.Send(new GetCashierDetailsQuery(id));

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet(ApiRoutes.Cashiers.BranchLookup)]
        public async Task<ActionResult<List<LookupResultDto>>> Lookups()
        {
            var result = await _mediator.Send(new GetBranchLookupsQuery());

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost(ApiRoutes.Cashiers.Create)]
        public async Task<ActionResult<List<int>>> Post([FromBody] CreateCashierCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut(ApiRoutes.Cashiers.Update)]
        public async Task<ActionResult<List<CashierDetailsResultDto>>> Put(int id, [FromBody] UpdateCashierCommand command)
        {
            command.ID = id;

            var result = await _mediator.Send(command);

            return Ok(result);
        }

    }
}
