using ColorApp.Debugging;

namespace ColorApp
{
    public class ColorAppConsts
    {
        public const string LocalizationSourceName = "ColorApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fceecc7f558b4bb98f7f592ec50ddc61";
    }
}
