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
    [Route("api/Item")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Item
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            List<Item> Items = await _context.Item.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Item> payload)
        {
            Item product = payload.value;
            _context.Item.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Item> payload)
        {
            Item product = payload.value;
            _context.Item.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Item> payload)
        {
            Item product = _context.Item
                .Where(x => x.ItemId == (int)payload.key)
                .FirstOrDefault();
            _context.Item.Remove(product);
            _context.SaveChanges();
            return Ok(product);

        }
    }
}