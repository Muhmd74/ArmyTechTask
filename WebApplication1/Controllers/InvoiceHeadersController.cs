using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using ArmyTechTask.Application.InvoiceHeaders.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Commons;

namespace WebApplication1.Controllers
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

            return Ok("result");
        }

    }
}
