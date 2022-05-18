using ArmyTechTask.Application.Cashiers.DTOs;
using ArmyTechTask.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.Cashiers.Queries
{
    public class GetCashiersQueryHandler : IRequestHandler<GetCashiersQuery, List<CashierListResultDto>>
    {
        private readonly ArmyTechTaskContext _context;
        private readonly IMapper _mapper;

        public GetCashiersQueryHandler(ArmyTechTaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CashierListResultDto>> Handle(GetCashiersQuery request, CancellationToken cancellationToken)
        {
            var cashiers = await _context.Cashier
                .Include(p => p.Branch)
                .ToListAsync(cancellationToken: cancellationToken);

            return _mapper.Map<List<CashierListResultDto>>(cashiers);
        }
    }
}
