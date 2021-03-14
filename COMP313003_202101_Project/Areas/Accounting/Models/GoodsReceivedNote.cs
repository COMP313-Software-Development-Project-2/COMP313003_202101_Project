using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class GoodsReceivedNote
    {
        [Key]
        [Required]
        [Display(Name = "GRN Id")]
        public int GoodsReceivedNoteId { get; set; }
        [Display(Name = "GRN Reference Name")]
        public string GoodsReceivedNoteName { get; set; }
        [Display(Name = "GRN Date")]
        public DateTimeOffset GRNDate { get; set; }
        [Display(Name = "Warehouse Id")]
        public int WarehouseId { get; set; }
        [Display(Name = "Purchase Order Id")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Vendor Delivery Order #")]
        public string DeliveryOrderId { get; set; }
        [Display(Name = "Bill Id")]
        public string BillId { get; set; }
        [Display(Name = "Invoice Id")]
        public string InvoiceId { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
        [Display(Name = "Full Receive")]
        public bool IsFullReceive { get; set; } = true;
    }
}
