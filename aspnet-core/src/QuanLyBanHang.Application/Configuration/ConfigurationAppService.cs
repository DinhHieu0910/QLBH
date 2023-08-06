using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QuanLyBanHang.Configuration.Dto;

namespace QuanLyBanHang.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QuanLyBanHangAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
