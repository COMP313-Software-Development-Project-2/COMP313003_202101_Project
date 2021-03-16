using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP313003_202101_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP313003_202101_Project.Controllers;
using COMP313003_202101_Project.Areas.Accounting.Controllers;
using COMP313003_202101_Project.Areas.Accounting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace COMP313003_202101_Project_Tests_Accounting
{
    public class Controllers
    {
        [TestClass]
        public class ClassBankController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    var controller = new BankController();

                    // Act
                    var result = controller.Index() as ViewResult;

                    // Assert
                    Assert.AreEqual(null, result.ViewName);
                }
            }
        }

        [TestClass]
        public class ClassBillController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    BillController controller = new BillController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassBillTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    BillTypeController controller = new BillTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassCurrencyController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    CurrencyController controller = new CurrencyController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassGoodsReceivedNoteController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    GoodsReceivedNoteController controller = new GoodsReceivedNoteController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassInvoiceController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    InvoiceController controller = new InvoiceController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassInvoiceTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    InvoiceTypeController controller = new InvoiceTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassPaymentReceiptController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    PaymentReceiptController controller = new PaymentReceiptController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassPaymentTypeController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    PaymentTypeController controller = new PaymentTypeController();

                    // Act
                    ViewResult result = controller.Index() as ViewResult;

                    // Assert
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestClass]
        public class ClassPaymentVoucherController
        {
            [TestClass]
            public class MethodIndex
            {
                [TestMethod]
                public void ReturnNull_IfNull()
                {
                    // Arrange
                    PaymentVoucherController controller = new PaymentVoucherController();

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