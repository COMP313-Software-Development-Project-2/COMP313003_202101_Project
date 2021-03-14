using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP313003_202101_Project.Models;
using COMP313003_202101_Project.Areas.Accounting.Models;
using COMP313003_202101_Project.Areas.Identity.Models;
using COMP313003_202101_Project.Areas.Inventory.Models;
using COMP313003_202101_Project.Areas.OrderFulfillment.Models;
using COMP313003_202101_Project.Areas.Orders.Models;

namespace COMP313003_202101_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        // Module: Financials
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillType> BillType { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<GoodsReceivedNote> GoodsReceivedNote { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceType> InvoiceType { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentReceipt> PaymentReceipt { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<PaymentVoucher> PaymentVoucher { get; set; }
        // Module: Inventories
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupType> GroupType { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        // Module: OrderFulfillment
        public DbSet<DeliveryOrder> DeliveryOrder { get; set; }
        public DbSet<DeliveryOrderType> DeliveryOrderType { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<ShipmentType> ShipmentType { get; set; }
        // Module: Purchases
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public DbSet<PurchaseType> PurchaseType { get; set; }
        // Module: Sales
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<SalesOrderLine> SalesOrderLine { get; set; }
        public DbSet<SalesType> SalesType { get; set; }
        // Module: Users
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerType> CustomerType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<VendorType> VendorType { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        // Shared
        public DbSet<NumberSequence> NumberSequence { get; set; }
    }
}
