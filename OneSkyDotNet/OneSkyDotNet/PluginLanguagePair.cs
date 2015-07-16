namespace OneSkyDotNet
{
    internal class PluginLanguagePair : IPluginLanguagePair
    {
        private const string GetAddress = "https://plugin.api.onesky.io/1/language-pairs";

        private const string GetFromLocaleParam = "from_locale";

        private OneSky oneSky;

        internal PluginLanguagePair(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetLanguagePairs(string fromLocale)
        {
            return this.oneSky.CreateRequest(GetAddress).Parameter(GetFromLocaleParam, fromLocale).Get();
        }
    }
}