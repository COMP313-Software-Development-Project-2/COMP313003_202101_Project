using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Pages
{
    public static class MainMenu
    {
        public static class Customer
        {
            public const string PageName = "Customer";
            public const string RoleName = "Supplier";
            public const string Path = "/Identity/Customer/Index";
            public const string ControllerName = "Customer";
            public const string ActionName = "Index";
        }

        public static class Vendor
        {
            public const string PageName = "Vendor";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/Vendor/Index";
            public const string ControllerName = "Vendor";
            public const string ActionName = "Index";
        }

        public static class Item
        {
            public const string PageName = "Item";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/Item/Index";
            public const string ControllerName = "Product";
            public const string ActionName = "Index";
        }

        public static class PurchaseOrder
        {
            public const string PageName = "Purchase Order";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/PurchaseOrder/Index";
            public const string ControllerName = "PurchaseOrder";
            public const string ActionName = "Index";
        }

        public static class GoodsReceivedNote
        {
            public const string PageName = "Goods Received Note";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/GoodsReceivedNote/Index";
            public const string ControllerName = "GoodsReceivedNote";
            public const string ActionName = "Index";
        }

        public static class Bill
        {
            public const string PageName = "Bill";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/Bill/Index";
            public const string ControllerName = "Bill";
            public const string ActionName = "Index";
        }

        public static class PaymentVoucher
        {
            public const string PageName = "Payment Voucher";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/PaymentVoucher/Index";
            public const string ControllerName = "PaymentVoucher";
            public const string ActionName = "Index";
        }

        public static class SalesOrder
        {
            public const string PageName = "Sales Order";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Orders/SalesOrder/Index";
            public const string ControllerName = "SalesOrder";
            public const string ActionName = "Index";
        }

        public static class Shipment
        {
            public const string PageName = "Shipment";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/OrderFulfillment/Shipment/Index";
            public const string ControllerName = "Shipment";
            public const string ActionName = "Index";
        }

        public static class Invoice
        {
            public const string PageName = "Invoice";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/Invoice/Index";
            public const string ControllerName = "Invoice";
            public const string ActionName = "Index";
        }

        public static class PaymentReceipt
        {
            public const string PageName = "Payment Receive";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/PaymentReceipt/Index";
            public const string ControllerName = "PaymentReceipt";
            public const string ActionName = "Index";
        }

        public static class BillType
        {
            public const string PageName = "Bill Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/BillType/Index";
            public const string ControllerName = "BillType";
            public const string ActionName = "Index";
        }

        public static class Branch
        {
            public const string PageName = "Branch";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/Branch/Index";
            public const string ControllerName = "Branch";
            public const string ActionName = "Index";
        }

        public static class Bank
        {
            public const string PageName = "Bank";
            public const string RoleName = "Supplier,Merchantk";
            public const string Path = "/Accounting/Bank/Index";
            public const string ControllerName = "Bank";
            public const string ActionName = "Index";
        }

        public static class Currency
        {
            public const string PageName = "Currency";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/Currency/Index";
            public const string ControllerName = "Currency";
            public const string ActionName = "Index";
        }

        public static class CustomerType
        {
            public const string PageName = "Customer Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/CustomerType/Index";
            public const string ControllerName = "CustomerType";
            public const string ActionName = "Index";
        }

        public static class InvoiceType
        {
            public const string PageName = "Invoice Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/InvoiceType/Index";
            public const string ControllerName = "InvoiceType";
            public const string ActionName = "Index";
        }

        public static class PaymentType
        {
            public const string PageName = "Payment Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/PaymentType/Index";
            public const string ControllerName = "PaymentType";
            public const string ActionName = "Index";
        }

        public static class ItemType
        {
            public const string PageName = "Item Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/ItemType/Index";
            public const string ControllerName = "ItemType";
            public const string ActionName = "Index";
        }

        public static class SalesType
        {
            public const string PageName = "Sales Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Orders/SalesType/Index";
            public const string ControllerName = "SalesType";
            public const string ActionName = "Index";
        }

        public static class ShipmentType
        {
            public const string PageName = "Shipment Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/OrderFulfillment/ShipmentType/Index";
            public const string ControllerName = "ShipmentType";
            public const string ActionName = "Index";
        }

        public static class UnitOfMeasure
        {
            public const string PageName = "Unit Of Measure";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/UnitOfMeasure/Index";
            public const string ControllerName = "UnitOfMeasure";
            public const string ActionName = "Index";
        }

        public static class VendorType
        {
            public const string PageName = "Vendor Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/VendorType/Index";
            public const string ControllerName = "VendorType";
            public const string ActionName = "Index";
        }

        public static class Warehouse
        {
            public const string PageName = "Warehouse";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Inventory/Warehouse/Index";
            public const string ControllerName = "Warehouse";
            public const string ActionName = "Index";
        }

        public static class PurchaseType
        {
            public const string PageName = "Purchase Type";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Accounting/PurchaseType/Index";
            public const string ControllerName = "PurchaseType";
            public const string ActionName = "Index";
        }

        public static class User
        {
            public const string PageName = "User";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/UserRole/Index";
            public const string ControllerName = "UserRole";
            public const string ActionName = "Index";
        }

        public static class ChangePassword
        {
            public const string PageName = "Change Password";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/UserRole/ChangePassword";
            public const string ControllerName = "UserRole";
            public const string ActionName = "ChangePassword";
        }

        public static class Role
        {
            public const string PageName = "Role";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/UserRole/Role";
            public const string ControllerName = "UserRole";
            public const string ActionName = "Role";
        }

        public static class ChangeRole
        {
            public const string PageName = "Change Role";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/UserRole/ChangeRole";
            public const string ControllerName = "UserRole";
            public const string ActionName = "ChangeRole";
        }

        public static class Dashboard
        {
            public const string PageName = "Dashboard Main";
            public const string RoleName = "Supplier,Merchant";
            public const string Path = "/Identity/Dashboard/Index";
            public const string ControllerName = "Dashboard";
            public const string ActionName = "Index";
        }

    }
}
