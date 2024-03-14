using Abp.Application.Services;
using LibraryProject.Services.EventServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventServices
{
    public interface IEventAppService : IApplicationService
    {
        Task<EventDto> CreateEventAsync(EventDto input);
        Task<EventDto> UpdateEventAsync(EventDto input);
        Task Delete(Guid id);
        Task<EventDto> GetByEventId(Guid id);
        Task<List<EventDto>> GetAllEventAsync();

    }
}