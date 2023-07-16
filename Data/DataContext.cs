using InvoiceAppAPI.Entity;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Customer> customers = new List<Customer>();
        List<Invoice> invoices = new List<Invoice>();

        for(int i = 1; i <= 100; i++)
        {
            var customer = new Customer
            {
                CustomerId = i,
                Name = $"Customer {i}",
                IdentityCard = $"IC00{i}"
            };
            customers.Add(customer);

            var invoice = new Invoice
            {
                Id = i,
                CustomerId = i,
                Amount = (decimal)(100.00 + i), // Explicitly cast to decimal
                Status = i % 2 == 0 ? "Paid" : "Unpaid",
                Date = DateTime.Now.AddDays(-i)
            };
            invoices.Add(invoice);
        }

        modelBuilder.Entity<Customer>().HasData(customers);
        modelBuilder.Entity<Invoice>().HasData(invoices);
    }
}
