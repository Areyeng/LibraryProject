using Abp.Domain.Entities.Auditing;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.MyLibraries
{
    public class MyLibrary : FullAuditedEntity<Guid>
    {
        public virtual Book Book { get; set; }
        public virtual Person Person { get; set; }
        public virtual bool Like { get; set; }
        public virtual bool Shelved { get; set; }
    }
}
