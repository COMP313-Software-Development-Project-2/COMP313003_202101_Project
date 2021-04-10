using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Orders.Models
{
    public class PurchaseOrder
    {
        [Required]
        [Display(Name = "Purchase Order Id")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Merchant Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Purchase Order Name")]
        public string PurchaseOrderName { get; set; }
        [Display(Name = "Branch Id")]
        public int BranchId { get; set; }
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
        [Display(Name = "Order Date")]
        public DateTimeOffset OrderDate { get; set; }
        [Display(Name = "Delivery Date")] 
        public DateTimeOffset DeliveryDate { get; set; }

        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; }
        
        [Display(Name = "Purchase Type Id")]
        public int PurchaseTypeId { get; set; }
        [Display(Name = "Remarks")] 
        public string Remarks { get; set; }
        [Display(Name = "Amount")] 
        public double Amount { get; set; }
        [Display(Name = "SubTotal")] 
        public double SubTotal { get; set; }
        [Display(Name = "Discount")] 
        public double Discount { get; set; }
        [Display(Name = "Tax")] 
        public double Tax { get; set; }
        [Display(Name = "Freight")] 
        public double Freight { get; set; }
        [Display(Name = "Total")] 
        public double Total { get; set; }
        [Display(Name = "Purchase Order Lines")] 
        public List<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    }
}
