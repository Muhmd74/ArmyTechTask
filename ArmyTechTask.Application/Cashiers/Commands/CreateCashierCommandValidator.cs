using FluentValidation;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class CreateCashierCommandValidator : AbstractValidator<CreateCashierCommand>
    {
        public CreateCashierCommandValidator()
        {
            RuleFor(p => p.CashierName)
                .NotEmpty();

            RuleFor(p => p.BranchID)
                .NotEmpty();
        }
    }
}
