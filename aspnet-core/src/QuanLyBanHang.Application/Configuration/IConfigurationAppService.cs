using System.Threading.Tasks;
using QuanLyBanHang.Configuration.Dto;

namespace QuanLyBanHang.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
