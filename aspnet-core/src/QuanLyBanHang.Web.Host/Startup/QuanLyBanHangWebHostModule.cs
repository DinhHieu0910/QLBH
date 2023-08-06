using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuanLyBanHang.Configuration;

namespace QuanLyBanHang.Web.Host.Startup
{
    [DependsOn(
       typeof(QuanLyBanHangWebCoreModule))]
    public class QuanLyBanHangWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QuanLyBanHangWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuanLyBanHangWebHostModule).GetAssembly());
        }
    }
}
