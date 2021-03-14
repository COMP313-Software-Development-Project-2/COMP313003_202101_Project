using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class Currency
    {
        [Key]
        [Required]
        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; }
        [Required]
        [Display(Name = "Currency Name")]
        public string CurrencyName { get; set; }
        [Required]
        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
