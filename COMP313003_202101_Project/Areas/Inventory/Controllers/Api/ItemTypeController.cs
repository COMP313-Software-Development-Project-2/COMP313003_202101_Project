using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Inventory.Models;
using COMP313003_202101_Project.ViewModels.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace COMP313003_202101_Project.Areas.Inventory.Controllers.Api
{
    [Area("Inventory")]
    [Authorize]
    [Produces("application/json")]
    [Route("api/ItemType")]
    public class ItemTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemType
        [HttpGet]
        public async Task<IActionResult> GetProductType()
        {
            List<ItemType> Items = await _context.ItemType.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ItemType> payload)
        {
            ItemType productType = payload.value;
            _context.ItemType.Add(productType);
            _context.SaveChanges();
            return Ok(productType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ItemType> payload)
        {
            ItemType productType = payload.value;
            _context.ItemType.Update(productType);
            _context.SaveChanges();
            return Ok(productType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ItemType> payload)
        {
            ItemType productType = _context.ItemType
                .Where(x => x.ItemTypeId == (int)(long)payload.key)
                .FirstOrDefault();
            _context.ItemType.Remove(productType);
            _context.SaveChanges();
            return Ok(productType);

        }
    }
}