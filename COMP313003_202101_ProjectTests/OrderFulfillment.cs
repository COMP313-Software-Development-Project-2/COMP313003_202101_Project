using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP313003_202101_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP313003_202101_Project.Controllers;
using COMP313003_202101_Project.Areas.OrderFulfillment.Controllers;
using COMP313003_202101_Project.Areas.OrderFulfillment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace COMP313003_202101_Project_Tests_OrderFulfillment
{
    public class Controllers
    {
        [TestClass]
        public class ClassShipmentController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    var controller = new ShipmentController();

                    // Act
                    var result = controller.Index() as ViewResult;

                    // Assert
                    Assert.AreEqual(null, result.ViewName);
                }
            }
        }

        [TestClass]
        public class ClassShipmentTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    ShipmentTypeController controller = new ShipmentTypeController();

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