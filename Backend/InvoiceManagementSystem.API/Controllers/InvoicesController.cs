using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.BLL.Interfaces;

namespace InvoiceManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // ✅ GET: api/invoices
        [HttpGet]
        public async Task<IActionResult> GetAllInvoices()
        {
            var invoices = await _invoiceService.GetAllInvoicesAsync();
            return Ok(invoices);
        }

        // ✅ GET: api/invoices/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            // Validation
            if (id <= 0)
                return BadRequest("Invalid invoice ID");

            var invoice = await _invoiceService.GetInvoiceByIdAsync(id);

            if (invoice == null)
                return NotFound(new { message = $"Invoice with ID {id} not found" });

            return Ok(invoice);
        }
    }
}