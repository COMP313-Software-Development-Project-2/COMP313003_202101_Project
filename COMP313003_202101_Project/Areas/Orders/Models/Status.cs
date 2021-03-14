using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Orders.Models
{
    public enum Status
    {
        Requested = 0,
        Accepted = 1,
        Denied = 2,
        Processing = 3,
        Shipped = 4,
        Delivered = 5,
        OnHold = 6,
        Cancelled = 7,
        Returned = 8
    }
}
