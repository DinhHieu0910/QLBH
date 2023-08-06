using System.Threading.Tasks;
using Abp.Application.Services;
using QuanLyBanHang.Authorization.Accounts.Dto;

namespace QuanLyBanHang.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
