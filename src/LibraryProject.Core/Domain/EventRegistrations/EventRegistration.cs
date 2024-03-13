using Abp.Domain.Entities.Auditing;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.EventRegistrations
{
    public class EventRegistration : FullAuditedEntity<Guid>
    {
        public virtual Person Person { get; set; }
        public virtual Event Event {  get; set; } 
        public virtual bool IsRegistered { get; set; }
    }
}
