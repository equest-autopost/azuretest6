using System.Threading.Tasks;
using Abp.Application.Services;
using azuretest6.Authorization.Accounts.Dto;

namespace azuretest6.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
