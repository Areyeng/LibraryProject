using Abp.Domain.Entities.Auditing;

using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.SettingPreferences
{
    public class SettingPreference : FullAuditedEntity<Guid>
    {
       
        //Must add reflists
        public virtual bool Notifications {  get; set; }
        public virtual string PreferredAuthors { get; set; }

        public virtual Person Person { get; set; }
    }
}
