using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.RoomSlots;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.RoomSlotServices.Dtos
{
    [AutoMap(typeof(RoomSlot))]
    public class RoomSlotDto : EntityDto<Guid>
    {
        [NotMapped]
        public virtual TimeOnly time { get; set; }
        public virtual string timeDisplay { get; set; }
    }
}
