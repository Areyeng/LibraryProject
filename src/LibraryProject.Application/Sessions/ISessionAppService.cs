using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryProject.Sessions.Dto;

namespace LibraryProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
