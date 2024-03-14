using Abp.Application.Services;
using LibraryProject.Services.PersonServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices
{
     public interface IPersonAppService : IApplicationService
    {
        Task<PersonDto> CreatePersonAsync(PersonDto input);
        Task<PersonDto> UpdatePersonAsync(PersonDto input);
        Task Delete (Guid id);
        Task <PersonDto> GetByPersonId(Guid id);
        Task<List<PersonDto>> GetAllPersonAsync();
    }
}
