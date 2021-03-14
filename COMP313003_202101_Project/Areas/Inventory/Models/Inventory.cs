using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class Inventory
    {
        [Key]
        [Required]
        [Display(Name = "Inventory Id")]
        public int InventoryId { get; set; }
        [Required]
        [Display(Name = "Inventory Name")]
        public string InventoryName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Items")]
        public List<Item> Items { get; set; } = new List<Item>();
        [Display(Name = "Groups")]
        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
