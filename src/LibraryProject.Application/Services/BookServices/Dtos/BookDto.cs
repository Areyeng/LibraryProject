using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookServices.Dtos
{
    [AutoMap(typeof(Book))]
    public class BookDto : EntityDto<Guid>
    {
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string Description { get; set; }
        public virtual string Publisher { get; set; }

        public virtual int ISBN { get; set; }
        public virtual string Image { get; set; }
        public virtual string Genre { get; set; }
        public virtual int ShelfNumber { get; set; }
        public virtual int Like { get; set; }
    }
}
