using System.Threading.Tasks;
using Abp.Application.Services;
using QuanLyBanHang.Sessions.Dto;

namespace QuanLyBanHang.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
