using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.EventRegistrations;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventRegistrationServices.Dtos
{
    [AutoMap(typeof(EventRegistration))]
    public class EventRegistrationDto : EntityDto<Guid>
    {
        public virtual Person Person { get; set; }
        public virtual Event Event { get; set; }
        public virtual bool IsRegistered { get; set; }
    }
}
