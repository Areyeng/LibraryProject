using Abp.Application.Services;
using LibraryProject.Services.MemberServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MemberServices
{
    public interface IMemberAppService : IApplicationService
    {
        Task<MemberDto> CreateMemberAsync(MemberDto input);
        Task<MemberDto> UpdateMemberAsync(MemberDto input);
        Task<MemberDto> GetMemberAsync(Guid id);
        Task DeleteMember(Guid id);
    }
}
