using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryProject.Authorization.Accounts.Dto;

namespace LibraryProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
