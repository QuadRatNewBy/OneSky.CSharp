namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPluginLocale
    {
        IOneSkyResponse<string, IEnumerable<ILocale>> GetLocales();
    }
}