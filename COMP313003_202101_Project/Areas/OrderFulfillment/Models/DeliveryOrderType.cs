using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.OrderFulfillment.Models
{
    public class DeliveryOrderType
    {
        [Required]
        [Display(Name = "Delivery Type Id")]
        public int DeliveryTypeId { get; set; }
        [Required]
        [Display(Name = "Delivery Type Name")]
        public string DeliveryTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
