using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class Group
    {
        [Key]
        [Required]
        [Display(Name = "Group Id")]
        public int GroupId { get; set; }
        [Required]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        [Display(Name = "Group Type")]
        public string GroupType { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Items")]
        public List<Item> Items { get; set; } = new List<Item>();
        [Display(Name = "Inventory Id")]
        public int InventoryId { get; set; }

    }
}
