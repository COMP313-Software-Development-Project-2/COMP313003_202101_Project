using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class PaymentVoucher
    {
        [Key]
        [Required]
        [Display(Name = "Payment Voucher Id")]
        public int PaymentVoucherId { get; set; }
        [Display(Name = "Payment Voucher Name")]
        public string PaymentVoucherName { get; set; }
        [Display(Name = "Bill Id")]
        public int BillId { get; set; }
        [Display(Name = "Payment Date")]
        public DateTimeOffset PaymentDate { get; set; }
        [Display(Name = "Payment Type Id")]
        public int PaymentTypeId { get; set; }
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
