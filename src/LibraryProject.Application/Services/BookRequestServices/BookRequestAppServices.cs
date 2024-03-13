using Abp.Application.Services;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Services.BookRequestServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookRequestServices
{
    public class BookRequestAppServices : AsyncCrudAppService<BookRequest, BookRequestDto, Guid>
    {
        public BookRequestAppServices(Abp.Domain.Repositories.IRepository<BookRequest, Guid> repository) : base(repository)
        {
        }
    }
}
