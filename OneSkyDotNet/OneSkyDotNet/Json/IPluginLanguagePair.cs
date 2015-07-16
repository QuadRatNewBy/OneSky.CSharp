namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPluginLanguagePair
    {
        IOneSkyResponse<IMetaList, IEnumerable<ILocale>> GetLanguagePairs(string fromLocale);
    }
}