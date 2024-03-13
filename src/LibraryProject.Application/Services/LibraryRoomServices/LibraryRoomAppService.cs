using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.LibraryRooms;
using LibraryProject.Services.EventServices.Dto;
using LibraryProject.Services.LibraryRoomServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.LibraryRoomServices
{
    public class LibraryRoomAppService : AsyncCrudAppService<LibraryRoom, LibraryRoomDto, Guid>
    {
        public LibraryRoomAppService(IRepository<LibraryRoom, Guid> repository) : base(repository)
        {
        }
    }
}
