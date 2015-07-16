namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PluginLanguagePair : IPluginLanguagePair
    {
        private CSharp.IPluginLanguagePair languagePair;

        public PluginLanguagePair(CSharp.IPluginLanguagePair languagePair)
        {
            this.languagePair = languagePair;
        }

        public IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLanguagePairs(string fromLocale)
        {
            var plain = this.languagePair.GetLanguagePairs(fromLocale);
            var tuple = JsonHelper.PluginDeserialize(plain, new { locales = new List<Localeo>() }, x => x.locales);
            return new OneSkyResponse<IMeta, IEnumerable<ILocale>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}