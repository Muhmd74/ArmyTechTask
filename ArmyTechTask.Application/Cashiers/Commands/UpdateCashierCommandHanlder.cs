using ArmyTechTask.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class UpdateCashierCommandHandler : IRequestHandler<UpdateCashierCommand>
    {
        private readonly ArmyTechTaskContext _context;


        public UpdateCashierCommandHandler(ArmyTechTaskContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCashierCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Cashier.FirstOrDefaultAsync(p => p.ID == request.ID, cancellationToken: cancellationToken);

            if (entity == null)
                throw new Exception("Not Found");

            entity.CashierName = request.CashierName;
            entity.BranchID = request.BranchID;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
