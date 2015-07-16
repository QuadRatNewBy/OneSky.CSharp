namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PluginLanguagePair : IPluginLanguagePair
    {
        private OneSkyDotNet.IPluginLanguagePair languagePair;

        public PluginLanguagePair(OneSkyDotNet.IPluginLanguagePair languagePair)
        {
            this.languagePair = languagePair;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocale>> GetLanguagePairs(string fromLocale)
        {
            var plain = this.languagePair.GetLanguagePairs(fromLocale);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocale>, MetaList, List<Localeo>>(plain);
        }
    }
}