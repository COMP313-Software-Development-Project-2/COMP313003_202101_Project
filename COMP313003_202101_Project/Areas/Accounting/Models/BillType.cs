using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class BillType
    {
        [Key]
        [Required]
        [Display(Name = "Bill Id")]
        public int BillTypeId { get; set; }
        [Display(Name = "Bill Name")]
        public string BillTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
