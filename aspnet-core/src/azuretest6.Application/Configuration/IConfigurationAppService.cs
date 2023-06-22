using System.Threading.Tasks;
using azuretest6.Configuration.Dto;

namespace azuretest6.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
