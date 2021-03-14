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
    [Authorize]
    [Produces("application/json")]
    [Route("api/PaymentReceipt")]
    public class PaymentReceiveController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INumberSequence _numberSequence;

        public PaymentReceiveController(ApplicationDbContext context,
                        INumberSequence numberSequence)
        {
            _context = context;
            _numberSequence = numberSequence;
        }

        // GET: api/PaymentReceipt
        [HttpGet]
        public async Task<IActionResult> GetPaymentReceive()
        {
            List<PaymentReceipt> Items = await _context.PaymentReceipt.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<PaymentReceipt> payload)
        {
            PaymentReceipt paymentReceive = payload.value;
            paymentReceive.PaymentReceiptName = _numberSequence.GetNumberSequence("PAYRCV");
            _context.PaymentReceipt.Add(paymentReceive);
            _context.SaveChanges();
            return Ok(paymentReceive);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<PaymentReceipt> payload)
        {
            PaymentReceipt paymentReceive = payload.value;
            _context.PaymentReceipt.Update(paymentReceive);
            _context.SaveChanges();
            return Ok(paymentReceive);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<PaymentReceipt> payload)
        {
            PaymentReceipt paymentReceive = _context.PaymentReceipt
                .Where(x => x.PaymentReceiptId == (int)payload.key)
                .FirstOrDefault();
            _context.PaymentReceipt.Remove(paymentReceive);
            _context.SaveChanges();
            return Ok(paymentReceive);

        }
    }
}