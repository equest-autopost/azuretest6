using System.Threading.Tasks;
using Abp.Application.Services;
using azuretest6.Sessions.Dto;

namespace azuretest6.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
