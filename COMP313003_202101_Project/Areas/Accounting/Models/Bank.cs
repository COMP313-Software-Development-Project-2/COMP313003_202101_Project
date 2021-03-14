using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class Bank
    {
        [Key]
        [Required]
        [Display(Name = "Bank Id")]
        public int BankId { get; set; }
        [Display(Name = "Bank Name")]
        public string BankName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
