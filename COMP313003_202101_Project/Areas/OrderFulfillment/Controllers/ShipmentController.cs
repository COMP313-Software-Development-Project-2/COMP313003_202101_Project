using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP313003_202101_Project.Areas.OrderFulfillment.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Shipment.RoleName)]
    public class ShipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}