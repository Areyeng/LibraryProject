using Abp.Domain.Repositories;
using AutoMapper;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.SearchBooks;
using LibraryProject.Services.SearchBookServices.Dtos;
using LibraryProject.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.SearchBookServices
{
    public class SearchBookService
    {
        //private readonly IRepository<SearchBook, Guid> _searchBookRepository;

        //public SearchBookService(IRepository<SearchBook, Guid> searchBookRepository)
        //{
        //    _searchBookRepository = searchBookRepository;
        //}

        //public async Task<List<UserDto>> SearchUsers(SearchBookDto input)
        //{
        //    var query = _searchBookRepository.GetAll();

        //    if (!string.IsNullOrEmpty(input.Keyword))
        //    {
        //        query = query.Where(u => u.UserName.Contains(input.Keyword)
        //                              || u.Email.Contains(input.Keyword));
        //    }

            

        //    var users = await AsyncExecuter.ToListAsync(query);

        //    return ObjectMapper.Map<List<SearchBookDto>>(users);
        //}
    }
}
