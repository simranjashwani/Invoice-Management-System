using InvoiceManagementSystem.DAL.Entities;
using InvoiceManagementSystem.DAL.Enums;

namespace InvoiceManagementSystem.BLL.Interfaces
{
    public interface IInvoiceService
    {
        Task<Invoice> CreateInvoiceAsync(Invoice invoice);

        Task<List<Invoice>> GetAllInvoicesAsync();

        Task<Invoice?> GetInvoiceByIdAsync(int id);

        Task AddPaymentAsync(int invoiceId, decimal amount, string paymentMethod);

        Task ChangeInvoiceStatusAsync(int invoiceId, InvoiceStatus newStatus);

        Task GenerateAgingReportAsync();

        Task UpdateOverdueInvoicesAsync();

        Task CalculateDsoAsync();


        Task GenerateRevenueSummaryAsync();     //Revenue Summary Report
Task GenerateCustomerOutstandingReportAsync();  // Outstanding per Customer Report
Task GenerateReconciliationReportAsync();   // Financial Reconciliation Report
Task GenerateTopUnpaidInvoicesAsync();  // Top Unpaid Invoices Report
    }
}

