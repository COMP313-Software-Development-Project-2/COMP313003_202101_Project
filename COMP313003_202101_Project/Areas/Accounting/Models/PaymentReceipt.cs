using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public class PaymentReceipt
    {
        [Key]
        [Required]
        [Display(Name = "Payment Receipt Id")]
        public int PaymentReceiptId { get; set; }
        [Display(Name = "Payment Receipt Name")]
        public string PaymentReceiptName { get; set; }
        [Display(Name = "Invoice Id")]
        public int InvoiceId { get; set; }
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
