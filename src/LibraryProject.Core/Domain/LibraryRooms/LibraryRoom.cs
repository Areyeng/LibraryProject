using Abp.Domain.Entities.Auditing;
using LibraryProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.LibraryRooms
{
    public class LibraryRoom : FullAuditedEntity<Guid>
    {
        public virtual int RoomNumber { get; set; }
        //public virtual RefListRoomAvailability Availability { get; set; }
        //public virtual RefListRoomSize RoomSize { get; set; }
    }
}
