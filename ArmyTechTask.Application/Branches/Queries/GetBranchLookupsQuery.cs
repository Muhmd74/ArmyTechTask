using ArmyTechTask.Application.Commons.DTOs;
using ArmyTechTask.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.Branches.Queries
{
    public class GetBranchLookupsQuery : IRequest<List<LookupResultDto>>
    {
        private class GetBranchLookupsQueryHandler : IRequestHandler<GetBranchLookupsQuery, List<LookupResultDto>>
        {
            private readonly ArmyTechTaskContext _context;
            private readonly IMapper _mapper;

            public GetBranchLookupsQueryHandler(ArmyTechTaskContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<LookupResultDto>> Handle(GetBranchLookupsQuery request, CancellationToken cancellationToken)
            {
                var branches = await _context.Branches.ToListAsync(cancellationToken);

                return _mapper.Map<List<LookupResultDto>>(branches);
            }
        }

    }
}
