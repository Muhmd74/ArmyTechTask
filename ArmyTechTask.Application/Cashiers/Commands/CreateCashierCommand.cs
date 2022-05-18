using MediatR;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class CreateCashierCommand : IRequest<int>
    {
        public string CashierName { get; set; }

        public int BranchID { get; set; }
    }
}
