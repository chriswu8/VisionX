using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class InvoiceService
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        // public async Task<(List<Service> services, List<Product> products)> GetServicesAndProductsByPatient(int patientId)
        // {
        //     var invoices = await _context.Invoices
        //         .Where(i => i.PatientID == patientId)
        //         .ToListAsync();

        //     var serviceIds = invoices
        //         .Select(i => i.ServiceID)
        //         .Where(id => id.HasValue)
        //         .Distinct()
        //         .ToList();

        //     var productIds = invoices.Select(i => i.ProductID).Where(id => id.HasValue).Distinct().ToList();

        //     var services = await _context.Services
        //         .Where(s => serviceIds.Contains(s.Id))
        //         .ToListAsync();

        //     var products = await _context.Products
        //         .Where(p => productIds.Contains(p.ID))
        //         .ToListAsync();

        //     return (services, products);
        // }

        public async Task<(List<Service> services, List<Product> products, List<Invoice> invoices)> GetServicesAndProductsByPatient(int patientId)
        {
            var invoices = await _context.Invoices
                .Where(i => i.PatientID == patientId)
                .Include(i => i.Service)
                .Include(i => i.Product)
                .ToListAsync();

            var services = invoices
                .Where(i => i.Service != null)
                .Select(i => i.Service)
                .ToList();

            var products = invoices
                .Where(i => i.Product != null)
                .Select(i => i.Product)
                .ToList();

            return (services, products, invoices);
        }

        public List<Invoice> GetInvoicesByMonthAndYear(string month, string year)
        {
            // Assuming you want to match both month and year
            return _context.Invoices
                .Where(i => i.Month == month && i.Year == year && i.IsPaid == true)
                .Include(i => i.Patient)
                .Include(i => i.Service)
                .Include(i => i.Product)
                .ToList();
        }

        public async Task<Invoice> GetInvoiceById(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            return invoice;
        }

        public async Task<bool> UpdateInvoiceFee(int invoiceId, int newFee)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);

            if (invoice != null)
            {
                invoice.Fee = newFee;
                await _context.SaveChangesAsync();
                return true; // Indicates successful update
            }

            return false; // Indicates that the invoice with the given ID was not found
        }

        public async Task MarkInvoiceAsPaid(int invoiceId)
        {
            var invoice = _context.Invoices.Find(invoiceId);

            if (invoice != null)
            {
                // Update the IsPaid property
                invoice.IsPaid = true;

                // Save changes to the database
                _context.SaveChanges();
            }
        }

        // public async Task<(List<object> services, List<object> products)> GetServicesAndProductsByPatient(int patientId)
        // {
        //     var invoices = await _context.Invoices
        //         .Where(i => i.PatientID == patientId)
        //         .ToListAsync();

        //     var serviceIds = invoices
        //         .Select(i => i.ServiceID)
        //         .Where(id => id.HasValue)
        //         .Distinct()
        //         .ToList();

        //     var productIds = invoices
        //         .Select(i => i.ProductID)
        //         .Where(id => id.HasValue)
        //         .Distinct()
        //         .ToList();

        //     var services = await _context.Services
        //         .Where(s => serviceIds.Contains(s.Id))
        //         .Select(s => new
        //         {
        //             Service = s,
        //             InvoiceID = invoices.Any(i => i.ServiceID == s.Id) ? invoices.First(i => i.ServiceID == s.Id).ID : (int?)null
        //         })
        //         .ToListAsync();

        //     var products = await _context.Products
        //         .Where(p => productIds.Contains(p.ID))
        //         .Select(p => new
        //         {
        //             Product = p,
        //             InvoiceID = invoices.Any(i => i.ProductID == p.ID) ? invoices.First(i => i.ProductID == p.ID).ID : (int?)null
        //         })
        //         .ToListAsync();

        //     return (services.Cast<object>().ToList(), products.Cast<object>().ToList());
        // }

        //     public async Task<(List<ServiceWithInvoice> services, List<ProductWithInvoice> products)> GetServicesAndProductsByPatient(int patientId)
        //     {
        //         var invoices = await _context.Invoices
        //             .Where(i => i.PatientID == patientId)
        //             .ToListAsync();

        //         var serviceIds = invoices
        //             .Where(i => i.ServiceID.HasValue)
        //             .Select(i => i.ServiceID.Value)
        //             .Distinct()
        //             .ToList();

        //         var productIds = invoices
        //             .Where(i => i.ProductID.HasValue)
        //             .Select(i => i.ProductID.Value)
        //             .Distinct()
        //             .ToList();

        //         var services = await _context.Services
        // .Join(
        //     _context.Invoices
        //         .Where(i => i.PatientID == patientId && i.ServiceID.HasValue)
        //         .Select(i => new { ServiceID = i.ServiceID.Value, InvoiceID = i.ID }),
        //     s => s.Id,
        //     i => i.ServiceID,
        //     (s, i) => new ServiceWithInvoice { Service = s, InvoiceID = i.InvoiceID }
        // )
        // .ToListAsync();

        //         var products = await _context.Products
        // .Join(
        //     _context.Invoices
        //         .Where(i => i.PatientID == patientId && i.ProductID.HasValue)
        //         .Select(i => new { ProductID = i.ProductID.Value, InvoiceID = i.ID }),
        //     p => p.ID,
        //     i => i.ProductID,
        //     (p, i) => new ProductWithInvoice { Product = p, InvoiceID = i.InvoiceID }
        // )
        // .ToListAsync();
        //         return (services, products);
        //     }



        public async Task<int> CalculateTotalFeeByPatient(int patientId)
        {
            var (services, products, invoices) = await GetServicesAndProductsByPatient(patientId);

            // Calculate the total fee based on services and products
            int totalFee = 0;

            if (services != null)
            {
                // Calculate the total fee of services only for unpaid invoices
                totalFee += invoices
                    .Where(invoice => !invoice.IsPaid && services.Any(service => service.Id == invoice.ServiceID))
                    .Sum(invoice => (int)invoice.Service?.Fee);
            }

            if (products != null && invoices != null)
            {
                // Calculate the total fee of products only for unpaid invoices
                totalFee += invoices
                    .Where(invoice => !invoice.IsPaid && products.Any(product => product.ID == invoice.ProductID))
                    .Sum(invoice => (int)invoice.Product?.Fee);
            }

            Console.WriteLine(totalFee);

            return totalFee;
        }

        public async Task<bool> DeleteInvoice(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);

            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
                return true; // Indicates successful deletion
            }

            return false; // Indicates that the invoice with the given ID was not found
        }

        public async Task<bool> AddInvoice(Invoice invoice)
        {
            // Create a new Invoice instance

            // Add the new invoice to the context
            _context.Invoices.Add(invoice);

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true; // Indicates successful addition
        }

    }
}