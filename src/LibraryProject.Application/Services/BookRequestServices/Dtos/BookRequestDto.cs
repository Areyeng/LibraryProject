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
    [AutoMap(typeof(BookRequest))]
    public class BookRequestDto : EntityDto<Guid>
    {
        public virtual Book Book { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime BookRequestDate { get; set; }
        public virtual DateTime BookReturnDate { get; set; }

        public virtual bool Collected { get; set; }

        public virtual Person ReleasedBy { get; set; }
    }
}
