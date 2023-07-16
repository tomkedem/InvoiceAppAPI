using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InvoiceAppAPI.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
       
        public string Name { get; set; }   
       
        [MaxLength(20)]
        public string IdentityCard { get; set; }       
    }

}
