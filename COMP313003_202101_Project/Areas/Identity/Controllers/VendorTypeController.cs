﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using COMP313003_202101_Project.Pages;

namespace COMP313003_202101_Project.Areas.Identity.Controllers
{
    [Authorize(Roles = MainMenu.VendorType.RoleName)]
    public class VendorTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}