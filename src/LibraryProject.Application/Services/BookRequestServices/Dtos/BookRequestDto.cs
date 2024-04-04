using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookRequestServices.Dtos
{
    [AutoMapTo(typeof(BookRequest))]
    public class BookRequestDto : EntityDto<Guid>
    {
        public virtual Guid BookRequestedId { get; set; }
        public virtual Guid RequestorId { get; set; }
        public virtual DateTime RequestDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }
        public virtual bool Collected { get; set; }

        public virtual Guid ReleasorId { get; set; }
    }
}
