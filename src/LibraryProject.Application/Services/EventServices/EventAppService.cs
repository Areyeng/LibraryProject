using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Events;
using LibraryProject.Services.EventServices.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.EventServices
{
    public class EventAppService : ApplicationService, IEventAppService
    {

        private readonly IRepository<Event, Guid> _eventRepository;
        public EventAppService(IRepository<Event, Guid> eventRepository)
        {
            _eventRepository = eventRepository;
        }
        //Create
        [HttpPost]
        public async Task<EventDto> CreateEventAsync(EventDto input)
        {
            var eventinput = ObjectMapper.Map<Event>(input);
            eventinput = await _eventRepository.InsertAsync(eventinput);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<EventDto>(eventinput);
        }

        //Update
        [HttpPut]
        public async Task<EventDto> UpdateEventAsync(EventDto input)
        {
            var eventinput = ObjectMapper.Map<Event>(input);
            eventinput = await _eventRepository.UpdateAsync(eventinput);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<EventDto>(eventinput);
        }

        //Delete
        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _eventRepository.DeleteAsync(id);
        }

        //GetbyId
        [HttpGet]
        public async Task<EventDto> GetByEventId(Guid id)
        {
            var events = await _eventRepository.GetAsync(id);
            return ObjectMapper.Map<EventDto>(events);
        }
        
        //GetAll
        [HttpGet]
        public async Task<List<EventDto>> GetAllEventAsync()
        {
            var events = await _eventRepository.GetAllListAsync();
            return ObjectMapper.Map<List<EventDto>>(events);
        }
    }
}