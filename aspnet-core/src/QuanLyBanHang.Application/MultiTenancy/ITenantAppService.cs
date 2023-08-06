using Abp.Application.Services;
using QuanLyBanHang.MultiTenancy.Dto;

namespace QuanLyBanHang.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

