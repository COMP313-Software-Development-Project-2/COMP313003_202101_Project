using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP313003_202101_Project.Areas.Orders.Controllers
{
    [Area("Orders")]
    //[Authorize(Roles = Pages.MainMenu.SalesOrder.RoleName)]
    public class SalesOrderLineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}