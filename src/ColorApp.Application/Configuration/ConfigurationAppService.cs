using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ColorApp.Configuration.Dto;

namespace ColorApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ColorAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
