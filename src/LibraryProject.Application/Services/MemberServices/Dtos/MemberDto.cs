using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.Member;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Services.PersonServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MemberServices.Dtos
{
    [AutoMap(typeof(Member))]
    public class MemberDto : PersonDto
    {
        public string memberID { get; set; }
    }
}
