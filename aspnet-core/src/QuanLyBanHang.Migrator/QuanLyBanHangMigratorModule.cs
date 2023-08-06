using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuanLyBanHang.Configuration;
using QuanLyBanHang.EntityFrameworkCore;
using QuanLyBanHang.Migrator.DependencyInjection;

namespace QuanLyBanHang.Migrator
{
    [DependsOn(typeof(QuanLyBanHangEntityFrameworkModule))]
    public class QuanLyBanHangMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public QuanLyBanHangMigratorModule(QuanLyBanHangEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(QuanLyBanHangMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                QuanLyBanHangConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuanLyBanHangMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
