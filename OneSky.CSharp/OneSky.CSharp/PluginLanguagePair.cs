namespace OneSky.CSharp
{
    internal class PluginLanguagePair : IPluginLanguagePair
    {
        private const string GetAddress = "https://plugin.api.onesky.io/1/language-pairs";

        private const string GetFromLocaleParam = "from_locale";

        private OneSkyHelper oneSky;

        internal PluginLanguagePair(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetLanguagePairs(string fromLocale)
        {
            return this.oneSky.CreateRequest(GetAddress).Parameter(GetFromLocaleParam, fromLocale).Get();
        }
    }
}