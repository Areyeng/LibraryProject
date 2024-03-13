using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.Persons;
using LibraryProject.Domain.SettingPreferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.SettingPreferenceServices.Dtos
{
    [AutoMap(typeof(SettingPreference))]
    public class SettingPreferenceDto : EntityDto<Guid>
    {
        public virtual bool Notifications { get; set; }
        public virtual string PreferredAuthors { get; set; }

        public virtual Person Person { get; set; }
    }
}
