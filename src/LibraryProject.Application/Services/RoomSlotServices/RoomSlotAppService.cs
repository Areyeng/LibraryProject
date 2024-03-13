using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.RoomBookings;
using LibraryProject.Domain.RoomSlots;
using LibraryProject.Services.RoomBookingServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.RoomSlotServices
{
  
    public class RoomSlotAppService : AsyncCrudAppService<RoomSlot, RoomBookingDto, Guid>
    {
        public RoomSlotAppService(IRepository<RoomSlot, Guid> repository) : base(repository)
        {
        }
    }
}
