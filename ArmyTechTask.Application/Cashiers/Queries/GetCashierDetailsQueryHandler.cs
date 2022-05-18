using ArmyTechTask.Application.Cashiers.DTOs;
using ArmyTechTask.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.Cashiers.Queries
{
    public class GetCashierDetailsQueryHandler : IRequestHandler<GetCashierDetailsQuery, CashierDetailsResultDto>
    {
        private readonly ArmyTechTaskContext _context;
        private readonly IMapper _mapper;

        public GetCashierDetailsQueryHandler(ArmyTechTaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CashierDetailsResultDto> Handle(GetCashierDetailsQuery request, CancellationToken cancellationToken)
        {
            var cashier = await _context.Cashier
                .Include(p => p.Branch)
                .FirstOrDefaultAsync(p => p.ID == request.ID, cancellationToken: cancellationToken);

            return _mapper.Map<CashierDetailsResultDto>(cashier);
        }
    }
}
