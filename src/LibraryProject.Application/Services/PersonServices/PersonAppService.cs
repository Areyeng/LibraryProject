using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.PersonServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices
{
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, Guid>
    {
        public PersonAppService(IRepository<Person, Guid> repository) : base(repository)
        {
        }
    }
}
