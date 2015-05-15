namespace OneSkyDotNet.Json
{
    public interface IPlugin
    {
        IPluginLocale Locale { get; }

        IPluginSpecialization Specialization { get; }

        IPluginProject Project { get; }
    }
}