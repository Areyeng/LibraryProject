using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.RoomSlots
{
     public class RoomSlot : FullAuditedEntity<Guid>
    {
        [NotMapped]
        public virtual TimeOnly time {  get; set; }
        public virtual string timeDisplay { get; set; }                               
    }
}
