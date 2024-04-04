using AutoMapper;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.BookRequestServices.Dtos;
using LibraryProject.Services.MemberServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MemberServices
{
    public class BookRequestMapProfile : Profile 
    {
        //public BookRequestMapProfile()
        //{
        //    CreateMap<BookRequestDto, BookRequest>()
        //         .ForMember(u => u.Book.Id, options => options.MapFrom(e => e.BookRequestedId))
        //         .ForMember(u => u.Person.Id, options => options.MapFrom(e => e.RequestorId))
        //         .ForMember(u => u.ReleasedBy.Id, options => options.MapFrom(e => e.ReleasorId));

        //    CreateMap<BookRequest, BookRequestDto>()
        //        .ForMember(u => u.BookRequestedId, m => m.MapFrom(e => e.Book.Id))
        //        .ForMember(u => u.RequestorId, m => m.MapFrom(e => e.Person.Id))
        //        .ForMember(u => u.ReleasorId, m => m.MapFrom(e => e.ReleasedBy.Id));
        //}

        public BookRequestMapProfile()
        {
            CreateMap<BookRequestDto, BookRequest>()
                .ForMember(dest => dest.Book, opt => opt.Ignore())
                .ForMember(dest => dest.Person, opt => opt.Ignore()) // Ignore mapping for Person
                .ForMember(dest => dest.ReleasedBy, opt => opt.Ignore()); // Ignore mapping for ReleasedBy

            CreateMap<BookRequest, BookRequestDto>()
                .ForMember(dest => dest.BookRequestedId, m => m.MapFrom(src => src.Book != null ? src.Book.Id : (Guid?)null))
                .ForMember(dest => dest.RequestorId, m => m.MapFrom(src => src.Person.Id))
                .ForMember(dest => dest.ReleasorId, m => m.MapFrom(src => src.ReleasedBy.Id));
        }



    }
}

