using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.LibraryRooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.LibraryRoomServices.Dtos
{
    [AutoMap(typeof(LibraryRoom))]
    public class LibraryRoomDto : EntityDto<Guid>
    {
        public virtual int RoomNumber { get; set; }
    }
}
