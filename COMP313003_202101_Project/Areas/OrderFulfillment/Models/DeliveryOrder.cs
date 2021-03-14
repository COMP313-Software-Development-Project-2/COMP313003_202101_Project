using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.OrderFulfillment.Models
{
    public class DeliveryOrder
    {
        [Key]
        [Required]
        [Display(Name = "Delivery Order Id")]
        public int DeliveryOrderId { get; set; }
        [Display(Name = "Shipment Number")]
        public string DeliveryOrderName { get; set; }
        [Display(Name = "Delivery Date")]
        public DateTimeOffset DeliveryDate { get; set; }
        [Display(Name = "Delivery Type Id")]
        public int DeliveryTypeId { get; set; }
        [Display(Name = "Status Id")]
        public int Status { get; set; }
        [Display(Name = "Warehouse Id")]
        public int WarehouseId { get; set; }
        [Display(Name = "Purchase Order Id")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Sales Order Id")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Shipment Id")]
        public int ShipmentId { get; set; }
        [Display(Name = "Full Delivery")]
        public bool IsFullDelivery { get; set; } = true;
    }
}
