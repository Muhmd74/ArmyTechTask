using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using ArmyTechTask.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.InvoiceHeaders.Queries
{
    public class GetInvoiceHeaderListQueryHandler : IRequestHandler<GetInvoiceHeaderListQuery, List<InvoiceHeaderListResultDto>>
    {
        private readonly ArmyTechTaskContext _context;
        private readonly IMapper _mapper;

        public GetInvoiceHeaderListQueryHandler(IMapper mapper, ArmyTechTaskContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<InvoiceHeaderListResultDto>> Handle(GetInvoiceHeaderListQuery request, CancellationToken cancellationToken)
        {

            var invoice = await _context.InvoiceHeader
                .Include(p => p.Branch)
                .ToListAsync(cancellationToken: cancellationToken);

            return _mapper.Map<List<InvoiceHeaderListResultDto>>(invoice);
        }
    }
}
