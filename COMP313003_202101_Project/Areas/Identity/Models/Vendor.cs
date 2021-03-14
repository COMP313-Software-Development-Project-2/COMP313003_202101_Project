using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Identity.Models
{
    public class Vendor
    {
        [Key]
        [Required]
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
        [Required]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
        [Display(Name = "Vendor Type Id")]
        public int VendorTypeId { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
    }
}
