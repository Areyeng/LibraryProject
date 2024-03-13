using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Enums
{
    public enum RefListRoomSize : long
    {
        [Description("Small-Room")]
        small  = 5,
        [Description("Large-Room")]
        large = 10
    }
}
