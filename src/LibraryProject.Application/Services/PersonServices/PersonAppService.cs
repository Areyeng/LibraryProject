using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.PersonServices.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices
{
    public class PersonAppService : LibraryProjectAppServiceBase
    {
        private readonly IRepository<Person, Guid> _personRepository;
        public PersonAppService(IRepository<Person, Guid> personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        public async Task<PersonDto> CreatePersonAsync(PersonDto input)
        {
            var person = ObjectMapper.Map<Person>(input);
            person = await _personRepository.InsertAsync(person);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }
        [HttpPut]
        public async Task<PersonDto> UpdatePersonAsync(PersonDto input)
        {
            var person = ObjectMapper.Map<Person>(input);
            person = await _personRepository.UpdateAsync(person);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }
        [HttpDelete]
        public async Task Delete (Guid id)
        {
            await _personRepository.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PersonDto> GetByPersonId(Guid id)
        {
            var people = await _personRepository.GetAsync(id);
            return ObjectMapper.Map<PersonDto>(people);
        }

        [HttpGet]
        public async Task<List<PersonDto>> GetAllPeopleAsync()
        {
            var people = await _personRepository.GetAllListAsync();
            return ObjectMapper.Map<List<PersonDto>>(people);
        }


    }
}
