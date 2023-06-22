using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using azuretest6.MultiTenancy;

namespace azuretest6.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
