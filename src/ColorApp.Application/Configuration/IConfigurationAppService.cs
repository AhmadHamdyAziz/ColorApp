using System.Threading.Tasks;
using ColorApp.Configuration.Dto;

namespace ColorApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
