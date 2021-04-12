using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP313003_202101_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP313003_202101_Project.Controllers;
using COMP313003_202101_Project.Areas.Orders.Controllers;
using COMP313003_202101_Project.Areas.Orders.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using COMP313003_202101_Project.Data;

namespace COMP313003_202101_Project_Tests_Orders
{
    public class Controllers
    {
        [TestClass]
        public class ClassPurchaseOrderController
        {
            [TestClass]
            public class MethodIndex
            {
                private readonly ApplicationDbContext context;
                [TestMethod]
                public void ReturnNull_IfNull()
                {

                }
            }
        }

        [TestClass]
        public class ClassPurchaseOrderLineController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    PurchaseOrderLineController controller = new PurchaseOrderLineController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassPurchaseTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    PurchaseTypeController controller = new PurchaseTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassSalesOrderController
        {
            [TestClass]
            public class MethodIndex
            {
                private readonly ApplicationDbContext context;
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    SalesOrderController controller = new SalesOrderController(context);

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassSalesOrderLineController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    SalesOrderLineController controller = new SalesOrderLineController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassSalesTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    SalesTypeController controller = new SalesTypeController();

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