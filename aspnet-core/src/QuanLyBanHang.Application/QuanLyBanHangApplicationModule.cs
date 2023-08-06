using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuanLyBanHang.Authorization;

namespace QuanLyBanHang
{
    [DependsOn(
        typeof(QuanLyBanHangCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuanLyBanHangApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuanLyBanHangAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuanLyBanHangApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
