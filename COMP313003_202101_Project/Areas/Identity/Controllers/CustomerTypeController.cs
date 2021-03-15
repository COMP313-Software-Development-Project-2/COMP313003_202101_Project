using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using COMP313003_202101_Project.Pages;

namespace COMP313003_202101_Project.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize(Roles = MainMenu.CustomerType.RoleName)]
    public class CustomerTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}