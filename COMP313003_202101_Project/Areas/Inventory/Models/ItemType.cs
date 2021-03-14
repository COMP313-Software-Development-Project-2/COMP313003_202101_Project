using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class ItemType
    {
        [Key]
        [Required]
        [Display(Name = "Item Type Id")]
        public int ItemTypeId { get; set; }
        [Required]
        [Display(Name = "Item Type Name")]
        public string ItemTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
