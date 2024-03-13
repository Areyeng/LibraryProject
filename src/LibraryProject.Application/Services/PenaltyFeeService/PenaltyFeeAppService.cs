using Abp.Application.Services;
using Abp.Domain.Repositories;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Domain.PenaltyFee;
using LibraryProject.Services.MyLibraryServices.Dtos;
using LibraryProject.Services.PenaltyFeeService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PenaltyFeeService
{
    public class PenaltyFeeAppService : AsyncCrudAppService<PenaltyFee, PenaltyFeeDto, Guid>
    {
        public PenaltyFeeAppService(IRepository<PenaltyFee, Guid> repository) : base(repository)
        {
        }
    }
}
