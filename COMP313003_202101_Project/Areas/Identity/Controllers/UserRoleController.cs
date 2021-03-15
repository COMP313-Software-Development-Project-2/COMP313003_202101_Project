using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP313003_202101_Project.Areas.Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using COMP313003_202101_Project.Pages;

namespace COMP313003_202101_Project.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class UserRoleController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserRoleController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        [Authorize(Roles = MainMenu.User.RoleName)]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.ChangePassword.RoleName)]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.Role.RoleName)]
        public IActionResult Role()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.ChangeRole.RoleName)]
        public IActionResult ChangeRole()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            User user = await _userManager.GetUserAsync(User);
            return View(user);
        }
    }
}