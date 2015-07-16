namespace OneSkyDotNet.Json
{
    public interface IPlugin
    {
        IPluginLocale Locale { get; }

        IPluginSpecialization Specialization { get; }

        IPluginProject Project { get; }

        IPluginQuotation Quotation { get; }

        IPluginAccount Account { get; }

        IPluginLanguagePair LanguagePair { get; }

        IPluginItem Item { get; }

        IPluginOrder Order { get; }
    }
}