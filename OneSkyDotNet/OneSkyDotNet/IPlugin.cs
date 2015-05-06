namespace OneSkyDotNet
{
    public interface IPlugin
    {
        IPluginAccount Account { get; }

        IPluginLocale Locale { get; }

        IPluginSpecialization Specialization { get; }

        IPluginProject Project { get; }

        IPluginItem Item { get; }

        IPluginOrder Order { get; }

        IPluginQuotation Quotation { get; }
    }
}