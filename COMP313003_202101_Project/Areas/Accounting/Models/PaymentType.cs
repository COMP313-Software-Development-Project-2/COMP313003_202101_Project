using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class PaymentType
    {
        [Key]
        [Required]
        [Display(Name = "Payment Type Id")]
        public int PaymentTypeId { get; set; }
        [Display(Name = "Payment Type Name")]
        public string PaymentTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
