using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Services.EventServices.Dto;
using LibraryProject.Services.MyLibraryServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MyLibraryServices
{
    public class MyLibraryAppService: AsyncCrudAppService<MyLibrary, MyLibraryDto, Guid>
    {
        public MyLibraryAppService(IRepository<MyLibrary, Guid> repository) : base(repository)
        {
        }
    }
}
