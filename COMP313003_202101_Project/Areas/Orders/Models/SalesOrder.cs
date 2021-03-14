using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Orders.Models
{
    public class SalesOrder
    {
        [Required]
        [Display(Name = "Sales Order Id")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Sales Order Name")]
        public string SalesOrderName { get; set; }
        [Display(Name = "Branch Id")]
        public int BranchId { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Order Date")]
        public DateTimeOffset OrderDate { get; set; }
        [Display(Name = "Delivery Date")]
        public DateTimeOffset DeliveryDate { get; set; }
        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; }
        [Display(Name = "Customer Ref. Number")]
        public string CustomerRefNumber { get; set; }
        [Display(Name = "Sales Type Id")]
        public int SalesTypeId { get; set; }
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
        [Display(Name = "Sales Order Lines")] 
        public List<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();
    }
}
