using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace azuretest6.Localization
{
    public static class azuretest6LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(azuretest6Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(azuretest6LocalizationConfigurer).GetAssembly(),
                        "azuretest6.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
