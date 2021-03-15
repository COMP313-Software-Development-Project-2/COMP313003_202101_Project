using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Identity.Models;
using COMP313003_202101_Project.ViewModels.AccountViewModels;
using COMP313003_202101_Project.ViewModels.SyncfusionViewModels;
using COMP313003_202101_Project.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace COMP313003_202101_Project.Areas.Identity.Controllers.Api
{
    [Area("Identity")]
    [Authorize]
    [Produces("application/json")]
    [Route("api/Role")]
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoles _roles;

        public RoleController(ApplicationDbContext context,
                        UserManager<User> userManager,
                        RoleManager<IdentityRole> roleManager,
                        IRoles roles)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _roles = roles;
        }

        // GET: api/Role
        [HttpGet]
        public async Task<IActionResult> GetRole()
        {
            await _roles.GenerateRolesFromPagesAsync();

            List<IdentityRole> Items = new List<IdentityRole>();
            Items = _roleManager.Roles.ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        // GET: api/Role
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetRoleByUserId([FromRoute]string id)
        {
            await _roles.GenerateRolesFromPagesAsync();
            var user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles.ToList();
            List<UserRoleViewModel> Items = new List<UserRoleViewModel>();
            int count = 1;
            foreach (var item in roles)
            {
                bool isInRole = (await _userManager.IsInRoleAsync(user, item.Name)) ? true : false;
                Items.Add(new UserRoleViewModel { CounterId = count, UserId = id, RoleName = item.Name, IsHaveAccess = isInRole });
                count++;
            }
            
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUserRole([FromBody]CrudViewModel<UserRoleViewModel> payload)
        {
            UserRoleViewModel userRole = payload.value;
            if (userRole != null)
            {
                var user = await _userManager.FindByIdAsync(userRole.UserId);
                if (user != null)
                {
                    if (userRole.IsHaveAccess)
                    {
                        await _userManager.AddToRoleAsync(user, userRole.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, userRole.RoleName);
                    }
                }
            }
            return Ok(userRole);
        }
    }
}