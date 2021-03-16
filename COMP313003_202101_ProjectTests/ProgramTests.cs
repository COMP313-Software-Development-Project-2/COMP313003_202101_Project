using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP313003_202101_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP313003_202101_Project.Controllers;
using COMP313003_202101_Project.Areas.Identity.Controllers;
using COMP313003_202101_Project.Areas.Identity.Models;
using COMP313003_202101_Project.Areas.Inventory.Controllers.Api;

using Microsoft.AspNetCore.Mvc;
using COMP313003_202101_Project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace COMP313003_202101_Project.Tests
{
    [TestClass]
    public class ProgramTests
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        
        // testing the view returned by controller
        [TestMethod]
        public void CustomerControllerTest()
        {
            var controller = new CustomerController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(null, result.ViewName);
        }

        // 
        [TestMethod]
        public void CustomerTypeTest()
        {
            // Arrange
            CustomerTypeController controller = new Areas.Identity.Controllers.CustomerTypeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DashBoardControllerTest()
        {
            // Arrange
            DashboardController controller = new DashboardController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VendorControllerTest()
        {
            // Arrange
            VendorController controller = new VendorController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void VendorTypeControllerTest()
        //{
        //    // Arrange
        //    VendorTypeController controller = VendorTypeController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

    }
}