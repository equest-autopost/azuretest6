using Abp.Application.Services;
using azuretest6.MultiTenancy.Dto;

namespace azuretest6.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

