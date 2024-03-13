using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.RoomBookings;
using LibraryProject.Services.EventServices.Dto;
using LibraryProject.Services.RoomBookingServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.RoomBookingServices
{
    public class RoomBookingAppService : AsyncCrudAppService<RoomBooking, RoomBookingDto, Guid>
    {
        public RoomBookingAppService(IRepository<RoomBooking, Guid> repository) : base(repository)
        {
        }
    }
}
