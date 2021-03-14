using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class Bill
    {
        [Key]
        [Required]
        [Display(Name = "Bill Id")]
        public int BillId { get; set; }
        [Display(Name = "Bill Name")]
        public string BillName { get; set; }
        [Display(Name = "Bill Date")]
        public DateTimeOffset BillDate { get; set; }
        [Display(Name = "Bill Due Date")]
        public DateTimeOffset BillDueDate { get; set; }
        [Display(Name = "Bill Type Id")]
        public int BillTypeId { get; set; }
        [Display(Name = "Purchase Order Id")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Vendor Delivery Order Id")]
        public string DeliveryOrderId { get; set; }
        [Display(Name = "Vendor Invoice Id")]
        public string InvoiceId { get; set; }
        [Display(Name = "GRN Id")]
        public int GoodsReceivedNoteId { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
    }
}
