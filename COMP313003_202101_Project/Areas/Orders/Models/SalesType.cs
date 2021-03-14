using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Orders.Models
{
    public class SalesType
    {
        [Required]
        [Display(Name = "Sales Type Id")]
        public int SalesTypeId { get; set; }
        [Required]
        [Display(Name = "Sales Type Name")]
        public string SalesTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
