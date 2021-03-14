using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.OrderFulfillment.Models
{
    public class ShipmentType
    {
        [Required]
        [Display(Name = "Shipment Type Id")]
        public int ShipmentTypeId { get; set; }
        [Required]
        [Display(Name = "Shipment Type Name")]
        public string ShipmentTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
