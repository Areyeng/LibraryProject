using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices.Dtos
{
    public class PersonUpdateDto  
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual int Age { get; set; }
        public virtual string Email { get; set; }
        public virtual int RoleId { get; set; }

        public virtual string Occupation { get; set; }
        public virtual string IdNumber { get; set; }
        public virtual string PassportNumber { get; set; }

        public virtual long UserId { get; set; }
    }
}
