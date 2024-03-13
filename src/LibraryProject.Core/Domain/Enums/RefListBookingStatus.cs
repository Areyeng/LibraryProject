using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Enums
{
    public enum RefListBookingStatus
    {
        [Description("Occupied")]
        Occupied= 1,
        [Description("Available")]
        Available = 2,
        [Description("Pending")]
        Pending = 2
    }
}
