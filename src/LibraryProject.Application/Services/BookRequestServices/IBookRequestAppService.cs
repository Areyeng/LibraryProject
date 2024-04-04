using Abp.Application.Services;
using LibraryProject.Services.BookRequestServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookRequestServices
{
    public interface IBookRequestAppService : IApplicationService
    {
        Task<BookRequestDto> CreateBookRequestAsync(BookRequestDto input);
        Task<BookRequestDto> UpdateBookRequestAsync(BookRequestDto input);
        Task Delete(Guid id);
        Task<BookRequestDto> GetByBookRequestId(Guid id);
        Task<List<BookRequestDto>> GetAllBookRequestAsync();

    }
}
