using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.OrderFulfillment.Models
{
    public class Shipment
    {
        [Key]
        [Required]
        [Display(Name = "Shipment Id")]
        public int ShipmentId { get; set; }
        [Display(Name = "Shipment Name")]
        public string ShipmentName { get; set; }
        [Display(Name = "Shipment Date")]
        public DateTimeOffset ShipmentDate { get; set; }
        [Display(Name = "Shipment Type Id")]
        public int ShipmentTypeId { get; set; }
        [Display(Name = "Status Id")]
        public int Status { get; set; }
        [Display(Name = "Warehouse Id")]
        public int WarehouseId { get; set; }
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [Display(Name = "Full Shipment")]
        public bool IsFullShipment { get; set; } = true;
    }
}
