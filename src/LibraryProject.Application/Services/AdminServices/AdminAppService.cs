using Abp.Application.Services;
using LibraryProject.Domain.Admin;
using LibraryProject.Services.AdminServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.AdminServices
{
  
    public class AdminAppService : AsyncCrudAppService<Admin, AdminDto, Guid>
    {
        public AdminAppService(Abp.Domain.Repositories.IRepository<Admin, Guid> repository) : base(repository)
        {
        }
    }
}
