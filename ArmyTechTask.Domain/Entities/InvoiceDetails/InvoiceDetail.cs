using System;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;

namespace ArmyTechTask.Domain.Entities.InvoiceDetails
{
    public class InvoiceDetail
    {
        public int ID { get; set; }

        public string ItemName { get; set; }

        public float ItemCount { get; set; }

        public float ItemPrice { get; set; }

        public int InvoiceHeaderID { get; set; }

        public InvoiceHeader InvoiceHeader { get; set; }

    }
}
