using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MyLibraryServices.Dtos
{
    [AutoMap(typeof(MyLibrary))]
    public class MyLibraryDto : EntityDto<Guid>
    {
        public virtual Book Book { get; set; }
        public virtual Person Person { get; set; }
        public virtual bool Like { get; set; }
        public virtual bool Shelved { get; set; }
    }
}
