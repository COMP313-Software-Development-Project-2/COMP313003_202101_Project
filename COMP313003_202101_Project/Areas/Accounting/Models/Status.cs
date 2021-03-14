using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Accounting.Models
{
    public enum Status
    {
        Pending = 0,
        Complete = 1,
        Refunded = 2,
        Failed = 3,
        Abandoned = 4,
        Cancelled = 5,
        Revoked = 6
    }
}
