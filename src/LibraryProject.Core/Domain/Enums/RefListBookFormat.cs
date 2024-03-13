using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Enums
{
    public enum RefListBookFormat : long
    {
        [Description("E-Book")]
        EBook = 1,
        [Description("Print-Book")]
        PrintBook = 2
    }
}
