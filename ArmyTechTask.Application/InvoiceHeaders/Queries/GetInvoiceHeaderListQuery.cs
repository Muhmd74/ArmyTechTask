using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using MediatR;

namespace ArmyTechTask.Application.InvoiceHeaders.Queries
{
    public class GetInvoiceHeaderListQuery : IRequest<List<InvoiceHeaderListResultDto>>
    {

    }
}
