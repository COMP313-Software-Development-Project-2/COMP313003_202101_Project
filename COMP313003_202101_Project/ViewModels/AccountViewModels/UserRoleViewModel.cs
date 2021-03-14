using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.ViewModels.AccountViewModels
{
    public class UserRoleViewModel
    {
        public int CounterId { get; set; }
        public string ApplicationUserId { get; set; }
        public string RoleName { get; set; }
        public bool IsHaveAccess { get; set; }
    }
}
