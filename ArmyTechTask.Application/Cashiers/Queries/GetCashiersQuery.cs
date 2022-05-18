using ArmyTechTask.Application.Cashiers.DTOs;
using MediatR;

namespace ArmyTechTask.Application.Cashiers.Queries
{
    public class GetCashiersQuery : IRequest<List<CashierListResultDto>>
    {
    }
}
