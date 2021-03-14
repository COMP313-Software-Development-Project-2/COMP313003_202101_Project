using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class Item
    {
        [Key]
        [Required]
        [Display(Name = "Item Id")]
        public int ItemId { get; set; }
        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Quantity")]
        public string Quantity { get; set; }
        [Display(Name = "Item Image Url")]
        public string ItemImageUrl { get; set; }
        [Display(Name = "Unit Of Measure")]
        public int UnitOfMeasureId { get; set; }
        [Display(Name = "Buying Price")]
        public double BuyingPrice { get; set; } = 0.0;
        [Display(Name = "Selling Price")]
        public double SellingPrice { get; set; } = 0.0;
        [Display(Name = "Branch Id")]
        public int BranchId { get; set; }
        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; }
    }
}
