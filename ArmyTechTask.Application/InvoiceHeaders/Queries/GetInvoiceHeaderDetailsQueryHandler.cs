using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using ArmyTechTask.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.InvoiceHeaders.Queries
{
    public class GetInvoiceHeaderDetailsQueryHandler : IRequestHandler<GetInvoiceHeaderDetailsQuery, InvoiceHeaderDetailsResultDto>
    {
        private readonly ArmyTechTaskContext _context;
        private readonly IMapper _mapper;

        public GetInvoiceHeaderDetailsQueryHandler(ArmyTechTaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<InvoiceHeaderDetailsResultDto> Handle(GetInvoiceHeaderDetailsQuery request, CancellationToken cancellationToken)
        {
            var invoice = await _context.InvoiceHeader
                .Include(p => p.Branch)
                .Include(p => p.Details)
                .FirstOrDefaultAsync(p => p.ID == request.Id, cancellationToken: cancellationToken);

            return _mapper.Map<InvoiceHeaderDetailsResultDto>(invoice);
        }
    }
}
