using System;
using System.ComponentModel.DataAnnotations;
namespace InvoiceAppAPI.Entity
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
