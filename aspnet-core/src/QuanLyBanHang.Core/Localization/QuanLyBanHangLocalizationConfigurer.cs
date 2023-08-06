using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QuanLyBanHang.Localization
{
    public static class QuanLyBanHangLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(QuanLyBanHangConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(QuanLyBanHangLocalizationConfigurer).GetAssembly(),
                        "QuanLyBanHang.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
