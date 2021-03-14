using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Services
{
    public interface IRoles
    {
        Task GenerateRolesFromPagesAsync();

        Task AddToRoles(string applicationUserId);
    }
}
