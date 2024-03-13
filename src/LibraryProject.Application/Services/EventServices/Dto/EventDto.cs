using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventServices.Dto
{
    [AutoMap(typeof(Event))]
    public class EventDto: EntityDto<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime EventDate { get; set; }
        public virtual string Location { get; set; }

        public virtual bool Recursive { get; set; }
        public virtual DateTime RecursiveDate { get; set; }
    }
}
