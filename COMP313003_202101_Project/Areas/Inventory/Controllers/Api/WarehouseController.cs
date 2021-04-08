﻿using System;
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
    [Route("api/Warehouse")]
    public class WarehouseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarehouseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Warehouse
        [HttpGet]
        public async Task<IActionResult> GetWarehouse()
        {
            List<Warehouse> Items = await _context.Warehouse.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Warehouse> payload)
        {
            Warehouse warehouse = payload.value;
            _context.Warehouse.Add(warehouse);
            _context.SaveChanges();
            return Ok(warehouse);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Warehouse> payload)
        {
            Warehouse warehouse = payload.value;
            _context.Warehouse.Update(warehouse);
            _context.SaveChanges();
            return Ok(warehouse);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Warehouse> payload)
        {
            Warehouse warehouse = _context.Warehouse
                .Where(x => x.WarehouseId == (int)(long)payload.key)
                .FirstOrDefault();
            _context.Warehouse.Remove(warehouse);
            _context.SaveChanges();
            return Ok(warehouse);

        }
    }
}