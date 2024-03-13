using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices.Dtos
{
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<Guid>
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
