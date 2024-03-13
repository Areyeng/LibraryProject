using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Events;
using LibraryProject.Services.EventServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventServices
{
    public class EventAppService : AsyncCrudAppService<Event, EventDto, Guid>
    {
        public EventAppService(IRepository<Event, Guid> repository) : base(repository)
        {
        }
    }
}
