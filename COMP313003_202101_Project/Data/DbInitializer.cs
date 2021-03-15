using COMP313003_202101_Project.Areas.Identity.Models;
using COMP313003_202101_Project.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace COMP313003_202101_Project.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context,
           IFunctional functional)
        {
            context.Database.EnsureCreated();
            if (context.User.Any())
            {
                return; //if user is not empty, DB has been seed
            }

            await functional.Initialize();

            await functional.InitAppData();
        }
    }
}
