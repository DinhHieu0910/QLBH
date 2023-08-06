using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuanLyBanHang.EntityFrameworkCore;
using QuanLyBanHang.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QuanLyBanHang.Web.Tests
{
    [DependsOn(
        typeof(QuanLyBanHangWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QuanLyBanHangWebTestModule : AbpModule
    {
        public QuanLyBanHangWebTestModule(QuanLyBanHangEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuanLyBanHangWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QuanLyBanHangWebMvcModule).Assembly);
        }
    }
}