using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Enums
{
    public enum RefListRoomAvailability
    {
        [Description("Available")]
        Available= 1,
        [Description("NotAvailable")]
        NotAvailable = 2 
    }
}
