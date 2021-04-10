using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Orders.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP313003_202101_Project.Areas.Orders.Controllers
{
    [Area("Orders")]
    //[Authorize(Roles = Pages.MainMenu.PurchaseOrder.RoleName)]
    public class PurchaseOrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseOrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Merchant"))
            {
                return View("Add");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Detail(int id)
        {
            PurchaseOrder purchaseOrder = _context.PurchaseOrder.SingleOrDefault(x => x.PurchaseOrderId.Equals(id));

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }
    }
}