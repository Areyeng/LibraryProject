using AutoMapper;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.PersonServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PersonServices
{
    public class PersonMapProfile:Profile
    {
        public PersonMapProfile()
        {
            CreateMap<PersonDto, User>()
                .ForMember(x => x.Roles, y => y.Ignore())
                .ForMember(x => x.Id, m => m.Ignore())
                .ForMember(x => x.FullName, y => y.MapFrom(x => x.Name + " " + x.Surname))
                //.ForMember(x => x.PhoneNumber, y => y.MapFrom(x => x.CellNumber))
                //.ForMember(x => x.EmailAddress, y => y.MapFrom(x => x.Email))
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(x => x.Surname));
               //.ForMember(x => x.UserName, y => y.MapFrom(x => x.Email));

            CreateMap<PersonDto, Person>()
                .ForMember(x => x.User, m => m.Ignore())
                .ForMember(x => x.Id, m => m.Ignore());

            //CreateMap<Person, PersonDto>()
                //.ForMember(x => x.RoleNames, m => m.MapFrom(x => x.User != null ? x.User.Roles : null))
                //.ForMember(x=>x.UserId, m => m.MapFrom(x=>x.User != null ?x.User.Id :(long?)null));

        }
        
    }
}
