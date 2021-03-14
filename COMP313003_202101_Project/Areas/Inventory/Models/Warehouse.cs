using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class Warehouse
    {
        [Key]
        [Required]
        [Display(Name = "Warehouse Id")]
        public int WarehouseId { get; set; }
        [Required]
        [Display(Name = "Warehouse Name")]
        public string WarehouseName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Branch Id")]
        public int BranchId { get; set; }
    }
}
