using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Orders.Models
{
    public class SalesOrderLine
    {
        [Required]
        [Display(Name = "Sales Order Line Id")]
        public int SalesOrderLineId { get; set; }
        [Display(Name = "Sales Order Id")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Sales Order")]
        public SalesOrder SalesOrder { get; set; }
        [Display(Name = "Item Id")]
        public int ItemId { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Quantity")]
        public double Quantity { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Amount")]
        public double Amount { get; set; }
        [Display(Name = "Disc %")]
        public double DiscountPercentage { get; set; }
        [Display(Name = "Discount Amount")] 
        public double DiscountAmount { get; set; }
        [Display(Name = "SubTotal")] 
        public double SubTotal { get; set; }
        [Display(Name = "Tax %")]
        public double TaxPercentage { get; set; }
        [Display(Name = "Tax Amount")] 
        public double TaxAmount { get; set; }
        [Display(Name = "Total")] 
        public double Total { get; set; }
    }
}
