using ArmyTechTask.Domain.Entities.Cashiers;
using ArmyTechTask.Persistence;
using MediatR;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class CreateCashierCommandHandler : IRequestHandler<CreateCashierCommand, int>
    {
        private readonly ArmyTechTaskContext _context;

        public CreateCashierCommandHandler(ArmyTechTaskContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCashierCommand request, CancellationToken cancellationToken)
        {
            var entity = new Cashier()
            {
                CashierName = request.CashierName,
                BranchID = request.BranchID
            };

            _context.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ID;
        }
    }
}
