using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Accounting.Models;
using COMP313003_202101_Project.ViewModels.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace COMP313003_202101_Project.Areas.Accounting.Controllers.Api
{
    [Area("Accounting")]
    [Authorize]
    [Produces("application/json")]
    [Route("api/Bank")]
    public class CashBankController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CashBankController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Bank
        [HttpGet]
        public async Task<IActionResult> GetCashBank()
        {
            List<Bank> Items = await _context.Bank.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Bank> payload)
        {
            Bank cashBank = payload.value;
            _context.Bank.Add(cashBank);
            _context.SaveChanges();
            return Ok(cashBank);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Bank> payload)
        {
            Bank cashBank = payload.value;
            _context.Bank.Update(cashBank);
            _context.SaveChanges();
            return Ok(cashBank);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Bank> payload)
        {
            Bank cashBank = _context.Bank
                .Where(x => x.BankId == (int)(long)payload.key)
                .FirstOrDefault();
            _context.Bank.Remove(cashBank);
            _context.SaveChanges();
            return Ok(cashBank);

        }
    }
}