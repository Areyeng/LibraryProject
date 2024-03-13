using LibraryProject.Debugging;

namespace LibraryProject
{
    public class LibraryProjectConsts
    {
        public const string LocalizationSourceName = "LibraryProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9411a8b2298d4d8e9472f45adff01f6b";
    }
}
