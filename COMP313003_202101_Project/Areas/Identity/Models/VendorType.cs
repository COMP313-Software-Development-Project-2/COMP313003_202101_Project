using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Identity.Models
{
    public class VendorType
    {
        [Key]
        [Required]
        [Display(Name = "Vendor Type Id")]
        public int VendorTypeId { get; set; }
        [Required]
        [Display(Name = "Vendor Type Name")]
        public string VendorTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
