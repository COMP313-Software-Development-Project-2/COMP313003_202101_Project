﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP313003_202101_Project.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    //[Authorize(Roles = Pages.MainMenu.PaymentReceipt.RoleName)]
    public class PaymentReceiptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}