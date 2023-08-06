using Abp.MultiTenancy;
using QuanLyBanHang.Authorization.Users;

namespace QuanLyBanHang.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
