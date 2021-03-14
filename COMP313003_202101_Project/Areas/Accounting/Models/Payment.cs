using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class Payment
    {
        [Key]
        [Required]
        [Display(Name = "Payment Id")]
        public int PaymentId { get; set; }
        [Display(Name = "Payment Name")]
        public string PaymentName { get; set; }
        [Display(Name = "Bill / Invoice Id")]
        public int BillInvoiceId { get; set; }
        [Display(Name = "Payment Date")]
        public DateTimeOffset PaymentDate { get; set; }
        [Display(Name = "Payment Type Id")]
        public int PaymentTypeId { get; set; }
        [Display(Name = "Status Id")]
        public int StatusId { get; set; }
        [Display(Name = "Payment Amount")]
        public double PaymentAmount { get; set; }
        [Display(Name = "Bank Id")]
        public int BankId { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Vendor Id")]
        public int VendorId { get; set; }
        [Display(Name = "Full Payment")]
        public bool IsFullPayment { get; set; } = true;
    }
}
