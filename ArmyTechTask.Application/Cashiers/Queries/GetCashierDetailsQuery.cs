using ArmyTechTask.Application.Cashiers.DTOs;
using MediatR;

namespace ArmyTechTask.Application.Cashiers.Queries
{
    public class GetCashierDetailsQuery : IRequest<CashierDetailsResultDto>
    {
        public GetCashierDetailsQuery(int id)
        {
            ID = id;
        }
        public int ID { get; set; }
    }
}
