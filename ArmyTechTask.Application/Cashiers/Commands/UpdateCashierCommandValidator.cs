using FluentValidation;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class UpdateCashierCommandValidator : AbstractValidator<UpdateCashierCommand>
    {
        public UpdateCashierCommandValidator()
        {
            RuleFor(p => p.CashierName)
                .NotEmpty();

            RuleFor(p => p.BranchID)
                .NotEmpty();
        }
    }
}
