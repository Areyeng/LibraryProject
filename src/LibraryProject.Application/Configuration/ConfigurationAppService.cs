using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibraryProject.Configuration.Dto;

namespace LibraryProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibraryProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
