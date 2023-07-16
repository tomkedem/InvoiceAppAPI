using InvoiceAppAPI.Entity;
using InvoiceAppAPI.Models;

namespace InvoiceAppAPI.Repositories
{
    public interface IInvoiceRepository
    {
        Task<Invoice> AddInvoice(InvoiceAdd request);
        Task DeleteInvoice(int id);
        Task<Invoice> GetInvoice(int id);
        Task<(int totalCount, IEnumerable<InvoiceDto> invoices)> GetInvoices(SearchTemplate request);
        Task<Invoice> UpdateInvoice(InvoiceEdit request);
    }
}