using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.TestingServices.Dtos
{
    [AutoMap(typeof(TestingDto))]
    public class TestingDto : Entity<Guid>
    {
        public string name { get; set; }
        public Book book { get; set; }
    }
}
