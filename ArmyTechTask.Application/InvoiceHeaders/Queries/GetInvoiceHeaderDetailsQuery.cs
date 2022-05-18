using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using MediatR;

namespace ArmyTechTask.Application.InvoiceHeaders.Queries
{
    public class GetInvoiceHeaderDetailsQuery : IRequest<InvoiceHeaderDetailsResultDto>
    {
        public GetInvoiceHeaderDetailsQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
