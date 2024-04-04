using AutoMapper;
using LibraryProject.Authorization.Users;
using LibraryProject.Services.MemberServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MemberServices
{
    public class MemberMappingProfile : Profile 
    {
        public MemberMappingProfile()
        {
            CreateMap<MemberDto, User>()
            .ForMember(e => e.Id , d => d.Ignore()); 
        }
        
    }
}
