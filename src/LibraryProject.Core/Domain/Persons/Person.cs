using Abp.Domain.Entities.Auditing;
using LibraryProject.Authorization.Roles;
using LibraryProject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Persons
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual int Age { get; set; }
        public virtual string Email { get; set; }
        public virtual int RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role RoleModel { get; set; }

        public virtual string Occupation { get; set; }
        public virtual string IdNumber { get; set; }
        public virtual string PassportNumber { get; set; }
        public virtual long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User UserModel { get; set; }
    }
}
