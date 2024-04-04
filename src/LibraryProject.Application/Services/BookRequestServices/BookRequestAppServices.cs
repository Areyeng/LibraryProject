using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LibraryProject.Authorization;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Member;
using LibraryProject.Domain.Persons;
using LibraryProject.Services.BookRequestServices.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookRequestServices
{
    //[AbpAuthorize(PermissionNames.Pages_Librarian_Admin)]
    public class BookRequestAppServices : ApplicationService, IBookRequestAppService
    {
        private readonly IRepository<BookRequest, Guid> _bookRequestRepository;
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<Member, Guid> _memberRepository;
        private readonly IRepository<Person, Guid> _librarianRepository; 
        public BookRequestAppServices(IRepository<BookRequest, Guid> bookRequestRepository, 
            IRepository<Book, Guid> bookRepository,
            IRepository<Member, Guid> memberRepository,
            IRepository<Person, Guid> librarianRepository)
        {
            _bookRequestRepository = bookRequestRepository;
            _bookRepository = bookRepository;
            _librarianRepository = librarianRepository;
            _memberRepository = memberRepository; 
        }
        //Create
        [HttpPost]
        public async Task<BookRequestDto> CreateBookRequestAsync(BookRequestDto input)
        {
                var book = await _bookRepository.GetAsync(input.BookRequestedId);
                var member = await _memberRepository.GetAsync(input.RequestorId);
                var librarian = await _librarianRepository.GetAsync(input.BookRequestedId); // Assuming input.BookId refers to the Id of the book being requested
                var bookrequest = new BookRequest
                {
                    Book = book,
                    Person = member,
                    BookRequestDate = input.RequestDate,
                    BookReturnDate = input.ReturnDate,
                    ReleasedBy = librarian
                };

                var createdBookRequest = await _bookRequestRepository.InsertAsync(bookrequest);
                var createdBookRequestDto = ObjectMapper.Map<BookRequestDto>(createdBookRequest);

                return createdBookRequestDto;

        }


        //Update
        [HttpPut]
        public async Task<BookRequestDto> UpdateBookRequestAsync(BookRequestDto input)
        {
            var bookrequestinput = ObjectMapper.Map<BookRequest>(input);
            bookrequestinput = await _bookRequestRepository.UpdateAsync(bookrequestinput);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<BookRequestDto>(bookrequestinput);
        }

        //Delete
        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _bookRequestRepository.DeleteAsync(id);
        }

        //GetbyId
        [HttpGet]
        public async Task<BookRequestDto> GetByBookRequestId(Guid id)
        {
            var bookrequests = await _bookRequestRepository.GetAsync(id);
            return ObjectMapper.Map<BookRequestDto>(bookrequests);
        }

        //GetAll
        [HttpGet]
        //[AbpAuthorize(PermissionNames.Pages_Librarian_Admin)]
        public async Task<List<BookRequestDto>> GetAllBookRequestAsync()
        {
            var bookrequests = await _bookRequestRepository.GetAllListAsync();
            return ObjectMapper.Map<List<BookRequestDto>>(bookrequests);
        }

        //GetAll by person
        public async Task<List<BookRequestDto>> GetAllBookRequestByPerson(Guid personId)
        {
            var bookrequests = await _bookRequestRepository.GetAll().Where(x=>x.Person.Id == personId).ToListAsync();
            return ObjectMapper.Map<List<BookRequestDto>>(bookrequests);
        }
        //GetAll for specific month
        //public async Task<List<BookRequestDto>> GetAllBookRequestByMonth()
        //{
        //    var bookrequests = await _bookRequestRepository.GetAll().Where().ToListAsync();
        //    return ObjectMapper.Map<List<BookRequestDto>>(bookrequests);
        //}
        public async Task<List<BookRequestDto>> GetAllBookRequestByMonth()
        {
            // Get the current month and year
            var currentDate = DateTime.Now;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;

            // Filter book requests for the current month and year
            var bookRequests = await _bookRequestRepository
                .GetAll()
                .Where(request => request.BookRequestDate.Month == currentMonth && request.BookRequestDate.Year == currentYear)
                .ToListAsync();

            // Map BookRequest entities to BookRequestDto objects
            //var bookRequestDtos = _mapper.Map<List<BookRequestDto>>(bookRequests);


            return ObjectMapper.Map<List<BookRequestDto>>(bookRequests);
        }
    }
}
