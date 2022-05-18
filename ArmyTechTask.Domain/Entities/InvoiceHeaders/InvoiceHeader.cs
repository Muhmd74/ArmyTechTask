using ArmyTechTask.Domain.Entities.Branches;
using ArmyTechTask.Domain.Entities.Cashiers;
using ArmyTechTask.Domain.Entities.InvoiceDetails;

namespace ArmyTechTask.Domain.Entities.InvoiceHeaders
{
    public class InvoiceHeader
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int? CashierID { get; set; }

        public Cashier? Cashier { get; set; }

        public int BranchID { get; set; }

        public Branch Branch { get; set; }

        public ICollection<InvoiceDetail> Details { get; set; }
    }
}
