using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.UI;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.PersonServices.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices
{
    [AbpAuthorize]
    public class PersonAppService : ApplicationService,IPersonAppService
    {
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly UserManager _userManager;
        public PersonAppService(IRepository<Person, Guid> personRepository, UserManager userManager)
        {
            _personRepository = personRepository;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<PersonDto> CreateAsync(PersonDto input)
        {
            var person = ObjectMapper.Map<Person>(input);
            var user = await CreateUserAsync(input);
            person.User = user;
            person = await _personRepository.InsertAsync(person);

            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpGet]
        public async Task<PersonDto> GetAsync(Guid id)
        {
           var person = await _personRepository.GetAllIncluding(x=>x.User).FirstOrDefaultAsync(x=>x.Id == id);
            return ObjectMapper.Map<PersonDto> (person);    
        }

        [HttpGet]
        public async Task<List<PersonDto>> GetAllAsync()
        {
            var person = await _personRepository.GetAllIncluding(x => x.User).ToListAsync();
            return ObjectMapper.Map<List<PersonDto>>(person);
        }


        [HttpPut]
        public async Task<PersonDto> UpdateAsync(PersonDto input)
        {
            var person = await _personRepository.GetAllIncluding(x=>x.User).FirstOrDefaultAsync(x=>x.Id == input.Id);
            person = ObjectMapper.Map(input, person);
            person = await _personRepository.UpdateAsync(person);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _personRepository.DeleteAsync(id);
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
      

        private async Task<User> CreateUserAsync(PersonDto input)
        {
            var password = input?.Password;
            var user = ObjectMapper.Map<User>(input);
            user.Password = password;
            if (!string.IsNullOrEmpty(user.NormalizedUserName) && !string.IsNullOrEmpty(user.NormalizedEmailAddress))
                user.SetNormalizedNames();
            user.TenantId = AbpSession.TenantId;
            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);
            CheckErrors(await _userManager.CreateAsync(user, password));

            //if (input.RoleNames != null)
            //{
            //    CheckErrors(await _userManager.SetRolesAsync(user, input.RoleNames));
            //}

            CurrentUnitOfWork.SaveChanges();
            return user;
        }
    }
}
