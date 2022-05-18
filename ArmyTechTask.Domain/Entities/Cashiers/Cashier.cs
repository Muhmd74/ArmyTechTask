using System;
using ArmyTechTask.Domain.Entities.Branches;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;

namespace ArmyTechTask.Domain.Entities.Cashiers
{
    public class Cashier
    {
        public int ID { get; set; }

        public string CashierName { get; set; }

        public int BranchID { get; set; }

        public Branch Branch { get; set; }

        public ICollection<InvoiceHeader> InvoiceHeaders { get; set; }
    }
}
