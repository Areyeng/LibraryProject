using Abp.Domain.Entities.Auditing;
using LibraryProject.Domain.Enums;
using LibraryProject.Domain.LibraryRooms;
using LibraryProject.Domain.Persons;
using LibraryProject.Domain.RoomSlots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.RoomBookings
{
    public class RoomBooking : FullAuditedEntity<Guid>
    {
        public virtual Person Booker { get; set; }
        public virtual LibraryRoom Room {  get; set; }

        public virtual List<Person> GroupMembers{ get; set;}
        public virtual List<RoomSlot> TimeAvailability {  get; set; }
        //public virtual RefListRoomSize RoomSize { get; set; }
        //public virtual RefListBookingStatus RoomBookingStatus { get; set; }
    }
}
