using azuretest6.Debugging;

namespace azuretest6
{
    public class azuretest6Consts
    {
        public const string LocalizationSourceName = "azuretest6";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3aedc66813ea4bd39d3ae772db2d31fc";
    }
}
