using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Admin
{
    public class Admin : Person
    {
        public virtual string staffID { get; set; }
    }
}
