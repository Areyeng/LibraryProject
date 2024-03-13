using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.EventRegistrations;
using LibraryProject.Domain.Events;
using LibraryProject.Services.EventRegistrationServices.Dtos;
using LibraryProject.Services.EventServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventRegistrationServices
{
    public class EventRegistrationAppService : AsyncCrudAppService<EventRegistration, EventRegistrationDto, Guid>
    {
        public EventRegistrationAppService(IRepository<EventRegistration, Guid> repository) : base(repository)
        {
        }
    }
}
