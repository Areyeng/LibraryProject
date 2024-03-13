using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Persons;
using LibraryProject.Domain.SettingPreferences;
using LibraryProject.Services.SettingPreferenceServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.SettingPreferenceServices
{
    public class SettingPreferenceAppService : AsyncCrudAppService<SettingPreference, SettingPreferenceDto,Guid>
    {
        public SettingPreferenceAppService(IRepository<SettingPreference, Guid> repository) : base(repository)
        {
        }
    }
}
