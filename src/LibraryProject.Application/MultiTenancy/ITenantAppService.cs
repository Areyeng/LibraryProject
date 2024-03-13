using Abp.Application.Services;
using LibraryProject.MultiTenancy.Dto;

namespace LibraryProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

