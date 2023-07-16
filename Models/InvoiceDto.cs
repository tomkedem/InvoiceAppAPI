namespace InvoiceAppAPI.Entity
{
    public class InvoiceDto
    {
       
        public int Id { get; set; }

        
        public DateTime Date { get; set; }

       
        public string Status { get; set; }

       
        public decimal Amount { get; set; }

       
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

    }
}
