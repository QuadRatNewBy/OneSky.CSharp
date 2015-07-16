namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginLocale
    {
        IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLocales();
    }
}