using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP313003_202101_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP313003_202101_Project.Controllers;
using COMP313003_202101_Project.Areas.Inventory.Controllers;
using COMP313003_202101_Project.Areas.Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace COMP313003_202101_Project_Tests_Inventory
{ 
    public class Controllers
    {
        [TestClass]
        public class ClassBranchController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    var controller = new BranchController();

                    // Act
                    var result = controller.Index() as ViewResult;

                    // Assert
                    Assert.AreEqual(null, result.ViewName);
                }
            }
        }

        [TestClass]
        public class ClassItemController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                // Arrange
                ItemController controller = new ItemController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassItemTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    ItemTypeController controller = new ItemTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassUnitOfMeasureController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    UnitOfMeasureController controller = new UnitOfMeasureController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassWarehouseController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    WarehouseController controller = new WarehouseController();

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