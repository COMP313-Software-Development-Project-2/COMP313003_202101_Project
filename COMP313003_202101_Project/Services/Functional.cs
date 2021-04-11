using COMP313003_202101_Project.Data;
using COMP313003_202101_Project.Areas.Accounting.Models;
using COMP313003_202101_Project.Areas.Identity.Models;
using COMP313003_202101_Project.Areas.Inventory.Models;
using COMP313003_202101_Project.Areas.OrderFulfillment.Models;
using COMP313003_202101_Project.Areas.Orders.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Services
{
    public class Functional : IFunctional
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly IRoles _roles;
        private readonly UserSupplierDefaultOptions _userSupplierDefaultOptions;
        private readonly UserMerchantDefaultOptions _userMerchantDefaultOptions;
        private readonly UserAssociateDefaultOptions _userAssociateDefaultOptions;

        public Functional(
           UserManager<User> userManager,
           RoleManager<IdentityRole> roleManager,
           ApplicationDbContext context,
           SignInManager<User> signInManager,
           IRoles roles,
           IOptions<UserSupplierDefaultOptions> userSupplierDefaultOptions,
           IOptions<UserMerchantDefaultOptions> userMerchantDefaultOptions,
           IOptions<UserAssociateDefaultOptions> userAssociateDefaultOptions
           )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _signInManager = signInManager;
            _roles = roles;
            _userSupplierDefaultOptions = userSupplierDefaultOptions.Value;
            _userMerchantDefaultOptions = userMerchantDefaultOptions.Value;
            _userAssociateDefaultOptions = userAssociateDefaultOptions.Value;
        }

      

        public async Task InitAppData()
        {
            try
            {
               
                await _context.BillType.AddAsync(new BillType { BillTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.Branch.AddAsync(new Branch { BranchName = "Default" });
                await _context.SaveChangesAsync();

                await _context.Warehouse.AddAsync(new Warehouse { WarehouseName = "Default" });
                await _context.SaveChangesAsync();

                await _context.Bank.AddAsync(new Bank { BankName = "Default" });
                await _context.SaveChangesAsync();

                await _context.Currency.AddAsync(new Currency { CurrencyName = "Default", CurrencyCode = "USD" });
                await _context.SaveChangesAsync();

                await _context.InvoiceType.AddAsync(new InvoiceType { InvoiceTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.PaymentType.AddAsync(new PaymentType { PaymentTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.PurchaseType.AddAsync(new PurchaseType { PurchaseTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.SalesType.AddAsync(new SalesType { SalesTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.ShipmentType.AddAsync(new ShipmentType { ShipmentTypeName = "Default" });
                await _context.SaveChangesAsync();

                await _context.UnitOfMeasure.AddAsync(new UnitOfMeasure { UnitOfMeasureName = "PCS" });
                await _context.SaveChangesAsync();

                await _context.ItemType.AddAsync(new ItemType { ItemTypeName = "Default" });
                await _context.SaveChangesAsync();

                List<Item> Items = new List<Item>() {
                    new Item{ItemName = "Item 01"},
                    new Item{ItemName = "Item 02"},
                    new Item{ItemName = "Item 03"},
                    new Item{ItemName = "Item 04"},
                    new Item{ItemName = "Item 05"},
                    new Item{ItemName = "Item 06"},
                    new Item{ItemName = "Item 07"},
                    new Item{ItemName = "Item 08"},
                    new Item{ItemName = "Item 09"},
                    new Item{ItemName = "Item 10"},

                };
                await _context.Item.AddRangeAsync(Items);
                await _context.SaveChangesAsync();

                await _context.CustomerType.AddAsync(new CustomerType { CustomerTypeName = "Default" });
                await _context.SaveChangesAsync();

                List<Customer> customers = new List<Customer>() {
                    new Customer{CustomerName = "Customer 01", Address = "Address 01"},
                    new Customer{CustomerName = "Customer 02", Address = "Address 02"},
                    new Customer{CustomerName = "Customer 03", Address = "Address 03"},
                    new Customer{CustomerName = "Customer 04", Address = "Address 04"},
                    new Customer{CustomerName = "Customer 05", Address = "Address 05"},
                    new Customer{CustomerName = "Customer 06", Address = "Address 06"},
                    new Customer{CustomerName = "Customer 07", Address = "Address 07"},
                    new Customer{CustomerName = "Customer 08", Address = "Address 08"},
                    new Customer{CustomerName = "Customer 09", Address = "Address 09"},
                    new Customer{CustomerName = "Customer 10", Address = "Address 10"}
                };
                await _context.Customer.AddRangeAsync(customers);
                await _context.SaveChangesAsync();

                await _context.VendorType.AddAsync(new VendorType { VendorTypeName = "Default" });
                await _context.SaveChangesAsync();

                List<Vendor> vendors = new List<Vendor>() {
                    new Vendor{VendorName = "Vendor 01", Address = "Address 01"},
                    new Vendor{VendorName = "Vendor 02", Address = "Address 02"},
                    new Vendor{VendorName = "Vendor 03", Address = "Address 03"},
                    new Vendor{VendorName = "Vendor 04", Address = "Address 04"},
                    new Vendor{VendorName = "Vendor 05", Address = "Address 05"},
                    new Vendor{VendorName = "Vendor 06", Address = "Address 06"},
                    new Vendor{VendorName = "Vendor 07", Address = "Address 07"},
                    new Vendor{VendorName = "Vendor 08", Address = "Address 08"},
                    new Vendor{VendorName = "Vendor 09", Address = "Address 09"},
                    new Vendor{VendorName = "Vendor 10", Address = "Address 10"},
                };
                await _context.Vendor.AddRangeAsync(vendors);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task SendEmailBySendGridAsync(string apiKey, 
            string fromEmail, 
            string fromFullName, 
            string subject, 
            string message, 
            string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(fromEmail, fromFullName),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email, email));
            await client.SendEmailAsync(msg);

        }

        public async Task SendEmailByGmailAsync(string fromEmail,
            string fromFullName,
            string subject,
            string messageBody,
            string toEmail,
            string toFullName,
            string smtpUser,
            string smtpPassword,
            string smtpHost,
            int smtpPort,
            bool smtpSSL)
        {
            var body = messageBody;
            var message = new MailMessage();
            message.To.Add(new MailAddress(toEmail, toFullName));
            message.From = new MailAddress(fromEmail, fromFullName);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = smtpUser,
                    Password = smtpPassword
                };
                smtp.Credentials = credential;
                smtp.Host = smtpHost;
                smtp.Port = smtpPort;
                smtp.EnableSsl = smtpSSL;
                await smtp.SendMailAsync(message);

            }

        }

        public async Task Initialize()
        {
            try
            {
                string[] roleNames = { "Supplier", "Merchant", "Associate" };
                IdentityResult roleResult;

                foreach (var roleName in roleNames)
                {
                    var roleExist = await _roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        // Roles - Create, Seed
                        roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

                string[] userUserNames = {
                    _userSupplierDefaultOptions.UserName,
                    _userMerchantDefaultOptions.UserName,
                    _userSupplierDefaultOptions.UserName
                };

                string[] userEmails = {
                    _userSupplierDefaultOptions.Email,
                    _userMerchantDefaultOptions.Email,
                    _userSupplierDefaultOptions.Email
                };

                string[] userPasswords = {
                    _userSupplierDefaultOptions.Password,
                    _userMerchantDefaultOptions.Password,
                    _userSupplierDefaultOptions.Password
                };


                for (int i = 0; i < roleNames.Length; i++)
                {
                    var _user = await _userManager.FindByEmailAsync(userEmails[i]);
                    if (_user == null)
                    {
                        var user = new User
                        {
                            UserName = userUserNames[i],
                            Email = userEmails[i],
                            EmailConfirmed = true
                        };
                        var superUser = await _userManager.CreateAsync(user, userPasswords[i]);
                        if (superUser.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(user, roleNames[i]);

                            //add to user profile
                            UserProfile profile = new UserProfile();
                            profile.FirstName = user.UserName;
                            profile.Email = user.Email;
                            profile.UserId = user.Id;
                            await _context.UserProfile.AddAsync(profile);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<string> UploadFile(List<IFormFile> files, IHostingEnvironment env, string uploadFolder)
        {
            var result = "";

            var webRoot = env.WebRootPath;
            var uploads = System.IO.Path.Combine(webRoot, uploadFolder);
            var extension = "";
            var filePath = "";
            var fileName = "";


            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    extension = System.IO.Path.GetExtension(formFile.FileName);
                    fileName = Guid.NewGuid().ToString() + extension;
                    filePath = System.IO.Path.Combine(uploads, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                    result = fileName;

                }
            }

            return result;
        }

    }
}
