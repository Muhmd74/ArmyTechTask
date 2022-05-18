namespace ArmyTechTask.Application.InvoiceHeaders.DTOs
{
    public class InvoiceHeaderListResultDto
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string BranchName { get; set; }
    }
}
