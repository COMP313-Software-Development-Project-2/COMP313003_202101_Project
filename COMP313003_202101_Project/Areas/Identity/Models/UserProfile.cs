using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Identity.Models
{
    public class UserProfile
    {
        [Key]
        [Required]
        [Display(Name = "User Profile Id")]
        public int UserProfileId { get; set; }
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [Display(Name = "Email")] 
        public string Email { get; set; }
        [Display(Name = "Password")] 
        public string Password { get; set; }
        [Display(Name = "Confirm Password")] 
        public string ConfirmPassword { get; set; }
        [Display(Name = "Old Password")] 
        public string OldPassword { get; set; }
        [Display(Name = "Profile Picture")] 
        public string ProfilePicture { get; set; } = "/upload/blank-person.png";
        [Display(Name = "Application User Id")]
        public string ApplicationUserId { get; set; }
    }
}
