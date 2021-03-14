using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP313003_202101_Project.Areas.Inventory.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Branch.RoleName)]
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}