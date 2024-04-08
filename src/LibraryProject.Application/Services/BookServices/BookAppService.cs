﻿using Abp.Application.Services;
using Abp.Authorization;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Domain.Books;
using LibraryProject.Services.BookServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookServices
{
    //[AbpAuthorize]
    public class BookAppService: AsyncCrudAppService<Book, BookDto, Guid>
    {
        public BookAppService(Abp.Domain.Repositories.IRepository<Book, Guid> repository) : base(repository)
        {
        }
    }
}
