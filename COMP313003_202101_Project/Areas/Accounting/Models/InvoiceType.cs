using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class InvoiceType
    {
        [Key]
        [Required]
        [Display(Name = "Invoice Type Id")]
        public int InvoiceTypeId { get; set; }
        [Display(Name = "Invoice Type Name")]
        public string InvoiceTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
