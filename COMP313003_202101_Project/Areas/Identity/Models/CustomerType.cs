using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Identity.Models
{
    public class CustomerType
    {
        [Key]
        [Required]
        [Display(Name = "Customer Type Id")]
        public int CustomerTypeId { get; set; }
        [Required]
        [Display(Name = "Customer Type Name")]
        public string CustomerTypeName { get; set; }
        [Display(Name = "Description")] 
        public string Description { get; set; }
    }
}
