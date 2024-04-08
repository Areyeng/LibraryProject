using LibraryProject.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Testing
{
    public class Testing
    {
        public virtual string name { get; set; }
        public virtual Book book {  get; set; }
    }
}
