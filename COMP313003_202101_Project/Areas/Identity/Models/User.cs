using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace COMP313003_202101_Project.Areas.Identity.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [PersonalData]
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [PersonalData]
        [Display(Name = "DOB")] 
        public DateTime DOB { get; set; }
    }
}
