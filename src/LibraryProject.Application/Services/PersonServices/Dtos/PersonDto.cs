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
    public class PersonDto : EntityDto<Guid>
    {
        public  string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        
   
 
    }
}
