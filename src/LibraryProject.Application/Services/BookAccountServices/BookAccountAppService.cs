using Abp.Application.Services;
using LibraryProject.Domain.BookAccounts;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Services.BookAccountServices.Dtos;
using LibraryProject.Services.BookRequestServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookAccountServices
{

    public class BookAccountAppService : AsyncCrudAppService<BookAccount, BookAccountDto, Guid>
    {
        public BookAccountAppService(Abp.Domain.Repositories.IRepository<BookAccount, Guid> repository) : base(repository)
        {
        }
    }
}
