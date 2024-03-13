using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Enums
{
    public enum RefListFeeStatus
    {
        [Description("Paid")]
        Paid = 1,
        [Description("NotPaid")]
        NotPaid = 2,
        [Description("Cancelled")]
        Cancelled = 2
    }
}
