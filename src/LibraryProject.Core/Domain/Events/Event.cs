using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Events
{
    public class Event : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime EventDate { get; set; }
        public virtual string Location { get; set; }

        public virtual bool Recursive { get; set; }
        public virtual DateTime RecursiveDate { get; set; }

    }
}
