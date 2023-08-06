using Abp.Authorization;
using QuanLyBanHang.Authorization.Roles;
using QuanLyBanHang.Authorization.Users;

namespace QuanLyBanHang.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
