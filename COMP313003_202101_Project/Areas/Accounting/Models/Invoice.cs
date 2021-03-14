using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class Invoice
    {
        [Key]
        [Required]
        [Display(Name = "Invoice Id")]
        public int InvoiceId { get; set; }
        [Display(Name = "Invoice Number")]
        public string InvoiceName { get; set; }
        [Display(Name = "Invoice Date")]
        public DateTimeOffset InvoiceDate { get; set; }
        [Display(Name = "Invoice Due Date")]
        public DateTimeOffset InvoiceDueDate { get; set; }
        [Display(Name = "Invoice Type Id")]
        public int InvoiceTypeId { get; set; }
        [Display(Name = "Sales Order Id")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Shipment Id")]
        public int ShipmentId { get; set; }
        [Display(Name = "GRN Id")]
        public int GoodsReceivedNoteId { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
    }
}
