using System;
using ArmyTechTask.Domain.Entities.Cashiers;
using ArmyTechTask.Domain.Entities.Cities;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;

namespace ArmyTechTask.Domain.Entities.Branches
{
    public class Branch
    {
        public int ID { get; set; }

        public string BranchName { get; set; }

        public int CityID { get; set; }

        public City City { get; set; }

        public ICollection<Cashier> Cashiers { get; set; }

        public ICollection<InvoiceHeader> InvoiceHeaders { get; set; }

    }
}
