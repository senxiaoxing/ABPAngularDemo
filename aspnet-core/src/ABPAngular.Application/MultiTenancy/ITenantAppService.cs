using Abp.Application.Services;
using ABPAngular.MultiTenancy.Dto;

namespace ABPAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

