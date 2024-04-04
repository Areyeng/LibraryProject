using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Member
{
    public class Member : Person
    {
        public virtual string memberID { get; set; }
    }
}
