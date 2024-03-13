using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.LibraryRooms;
using LibraryProject.Domain.Persons;
using LibraryProject.Domain.RoomBookings;
using LibraryProject.Domain.RoomSlots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.RoomBookingServices.Dtos
{
    [AutoMap(typeof(RoomBooking))]
    public class RoomBookingDto : EntityDto<Guid>
    {
        public virtual Person Booker { get; set; }
        public virtual LibraryRoom Room { get; set; }

        public virtual List<Person> GroupMembers { get; set; }
        public virtual List<RoomSlot> TimeAvailability { get; set; }
    }
}
