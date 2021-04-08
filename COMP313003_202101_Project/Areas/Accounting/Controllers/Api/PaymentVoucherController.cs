using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Accounting.Models;
using COMP313003_202101_Project.Services;
using COMP313003_202101_Project.ViewModels.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace COMP313003_202101_Project.Controllers.Api
{
    [Area("Accounting")]
    [Authorize]
    [Produces("application/json")]
    [Route("api/PaymentVoucher")]
    public class PaymentVoucherController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INumberSequence _numberSequence;

        public PaymentVoucherController(ApplicationDbContext context,
                        INumberSequence numberSequence)
        {
            _context = context;
            _numberSequence = numberSequence;
        }

        // GET: api/PaymentVoucher
        [HttpGet]
        public async Task<IActionResult> GetPaymentVoucher()
        {
            List<PaymentVoucher> Items = await _context.PaymentVoucher.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<PaymentVoucher> payload)
        {
            PaymentVoucher paymentVoucher = payload.value;
            paymentVoucher.PaymentVoucherName = _numberSequence.GetNumberSequence("PAYVCH");
            _context.PaymentVoucher.Add(paymentVoucher);
            _context.SaveChanges();
            return Ok(paymentVoucher);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<PaymentVoucher> payload)
        {
            PaymentVoucher paymentVoucher = payload.value;
            _context.PaymentVoucher.Update(paymentVoucher);
            _context.SaveChanges();
            return Ok(paymentVoucher);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<PaymentVoucher> payload)
        {
            PaymentVoucher paymentVoucher = _context.PaymentVoucher
                .Where(x => x.PaymentVoucherId == (int)(long)payload.key)
                .FirstOrDefault();
            _context.PaymentVoucher.Remove(paymentVoucher);
            _context.SaveChanges();
            return Ok(paymentVoucher);

        }
    }
}