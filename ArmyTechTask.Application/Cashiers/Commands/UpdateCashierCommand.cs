using System.Text.Json.Serialization;
using MediatR;

namespace ArmyTechTask.Application.Cashiers.Commands
{
    public class UpdateCashierCommand : IRequest
    {
        [JsonIgnore]
        public int ID { get; set; }

        public string CashierName { get; set; }

        public int BranchID { get; set; }
    }
}
