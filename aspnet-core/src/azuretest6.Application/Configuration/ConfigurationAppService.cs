using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using azuretest6.Configuration.Dto;

namespace azuretest6.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : azuretest6AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
