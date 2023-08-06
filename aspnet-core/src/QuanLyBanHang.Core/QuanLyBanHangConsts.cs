using QuanLyBanHang.Debugging;

namespace QuanLyBanHang
{
    public class QuanLyBanHangConsts
    {
        public const string LocalizationSourceName = "QuanLyBanHang";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "aa467f6f36f54dcd900cd796a65060c7";
    }
}
