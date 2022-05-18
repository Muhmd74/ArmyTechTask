using ArmyTechTask.API.Commons;
using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using ArmyTechTask.Application.InvoiceHeaders.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArmyTechTask.API.Controllers
{
    public class InvoiceHeadersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InvoiceHeadersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet(ApiRoutes.InvoiceHeaders.GetAll)]
        public async Task<ActionResult<List<InvoiceHeaderListResultDto>>> Get()
        {
            var result = await _mediator.Send(new GetInvoiceHeaderListQuery());

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet(ApiRoutes.InvoiceHeaders.Get)]
        public async Task<ActionResult<List<InvoiceHeaderDetailsResultDto>>> GetById(int id)
        {
            var result = await _mediator.Send(new GetInvoiceHeaderDetailsQuery(id));

            return Ok(result);
        }

    }
}
