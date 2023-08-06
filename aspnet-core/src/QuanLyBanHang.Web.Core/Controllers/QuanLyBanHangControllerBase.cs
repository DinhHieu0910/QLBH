using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QuanLyBanHang.Controllers
{
    public abstract class QuanLyBanHangControllerBase: AbpController
    {
        protected QuanLyBanHangControllerBase()
        {
            LocalizationSourceName = QuanLyBanHangConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
