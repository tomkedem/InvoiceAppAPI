using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvoiceAppAPI.Models; // Replace with your actual Models namespace
using InvoiceAppAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using InvoiceAppAPI.Entity;
using System.Text.Json.Serialization;
using System.Text.Json;

[Route("api/[controller]")]
[ApiController]
public class InvoicesController : ControllerBase
{
    private readonly DataContext _context;
    private readonly IInvoiceRepository _repository;

    public InvoicesController(DataContext context, IInvoiceRepository repository)
    {
        _context = context;
        _repository = repository;
    }

    // GET: api/Invoices/search
    [HttpPost]
    [Route("/invoices/search")]   

    public virtual async Task<IActionResult> GetInvoices([FromBody] SearchTemplate request)
    {
        var (totalCount, invoices) = await _repository.GetInvoices(request);

       

        var response = new
        {
            TotalCount = totalCount,
            Invoices = invoices
        };

        return Ok(response);
    }
    // GET: api/Invoices/5
    [HttpGet]
    [Route("/invoices/{id}")]
    public async Task<ActionResult<Invoice>> GetInvoice(int id)
    {
        return Ok(await _repository.GetInvoice(id));
       
    }

    // PUT: api/Invoices/5
    [HttpPut]
    public async Task<IActionResult> PutInvoice(InvoiceEdit invoiceEdit)
    {
        return Ok(await _repository.UpdateInvoice(invoiceEdit));   
    }

    // POST: api/Invoices
    [HttpPost]
    public async Task<ActionResult<Invoice>> PostInvoice(InvoiceAdd InvoiceAdd)
    {
        var result = await _repository.AddInvoice(InvoiceAdd);
        return Ok(result);
    }

    // DELETE: api/Invoices/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInvoice(int id)
    {
        await _repository.DeleteInvoice(id);

        return NoContent();
    }

   
}