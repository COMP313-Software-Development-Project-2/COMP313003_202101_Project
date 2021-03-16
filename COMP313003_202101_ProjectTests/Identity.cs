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
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace COMP313003_202101_Project_Tests_Identity
{
    public class Controllers
    {
        [TestClass]
        public class ClassCustomerController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    var controller = new CustomerController();

                    // Act
                    var result = controller.Index() as ViewResult;

                    // Assert
                    Assert.AreEqual(null, result.ViewName);
                }
            }
        }

        [TestClass]
        public class ClassCustomerTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    CustomerTypeController controller = new CustomerTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassDashboardController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    DashboardController controller = new DashboardController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassUserRoleController
        {
            [TestClass]
            public class MethodIndex
            {
                private readonly UserManager<User> userManager;

                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    UserRoleController controller = new UserRoleController(userManager);

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassVendorController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    VendorController controller = new VendorController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }

            }            
        }

        [TestClass]
        public class ClassVendorTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    VendorTypeController controller = new VendorTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }
    }

    public class ControllersAPI
    {

    }
    
}