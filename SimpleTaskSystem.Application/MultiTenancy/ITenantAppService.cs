using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SimpleTaskSystem.MultiTenancy.Dto;

namespace SimpleTaskSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
