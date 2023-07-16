using InvoiceAppAPI.Entity;
using InvoiceAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Data.Common;
using AutoMapper;

namespace InvoiceAppAPI.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public InvoiceRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<(int totalCount, IEnumerable<InvoiceDto> invoices)> GetInvoices(SearchTemplate request)
        {

            var query = _context.Invoices
                .Include(i => i.Customer) // Include the related Customer entity
                .AsQueryable();

            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                query = query.Where(i =>
                    i.Id.ToString().Contains(request.SearchKey) ||
                    i.Date.ToString().Contains(request.SearchKey) ||
                    i.Status.Contains(request.SearchKey) ||
                    i.Amount.ToString().Contains(request.SearchKey) ||
                    i.CustomerId.ToString().Contains(request.SearchKey) ||
                    i.Customer.Name.Contains(request.SearchKey) // Include customer name in the search
                );
            }

            if (!string.IsNullOrEmpty(request.OrderByField))
            {
                if (request.OrderByField == "CustomerName")
                {
                    if (request.Sort == "asc")
                    {
                        query = query.OrderBy(i => i.Customer.Name);
                    }
                    else if (request.Sort == "desc")
                    {
                        query = query.OrderByDescending(i => i.Customer.Name);
                    }
                    else
                    {
                        // Default sort order
                        query = query.OrderBy(i => i.Customer.Name);
                    }
                }
                else
                {
                    // Handle sorting by other fields in the Invoice entity
                    if (request.Sort == "asc")
                    {
                        query = query.OrderBy(i => EF.Property<object>(i, request.OrderByField));
                    }
                    else if (request.Sort == "desc")
                    {
                        query = query.OrderByDescending(i => EF.Property<object>(i, request.OrderByField));
                    }
                    else
                    {
                        // Default sort order
                        query = query.OrderBy(i => EF.Property<object>(i, request.OrderByField));
                    }
                }
            }
            // Get the total count before pagination
            int totalCount = await query.CountAsync();

            query = query.Skip((request.PageNumber) * request.PageSize)
                         .Take(request.PageSize);
            var invoices = await query.Select(i => _mapper.Map<InvoiceDto>(i)).ToListAsync();


            return (totalCount, invoices);
        }
        public async Task<Invoice> GetInvoice(int id)
        {
            var resulte = await _context.Invoices.FindAsync(id);

            if (resulte == null)
            {
                throw new ArgumentException($"Could not find Invoice with ID {id}");
            }

            return resulte;
        }

        public async Task<Invoice> AddInvoice(InvoiceAdd request)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($"INSERT INTO Invoices (Amount, CustomerId, Date, Status) VALUES ({request.Amount}, {request.CustomerId}, GETDATE(), 'Unpaid')");

            // Retrieve the added invoice from the database
            var addedInvoice = await _context.Invoices
                .Include(i => i.Customer)
                .OrderByDescending(i => i.Id)
                .FirstOrDefaultAsync();

            return addedInvoice;
        }

        public async Task DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                throw new ArgumentException($"Could not find Invoice with ID {id}");
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task<Invoice> UpdateInvoice(InvoiceEdit request)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($"UPDATE Invoices SET Status = {request.Status}, Amount = {request.Amount} where id = {request.Id}");

            var editInvoice = await _context.Invoices
                                  .Include(i => i.Customer)
                                  .Where(i => i.Id == request.Id)
                                  .FirstOrDefaultAsync();

            return editInvoice;
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }

    }
}