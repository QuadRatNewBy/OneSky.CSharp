namespace OneSkyDotNet
{
    public class PluginLanguagePair : IPluginLanguagePair
    {
        private const string GetAddress = "https://platform.api.onesky.io/1/locales";

        private const string GetFromLocaleParam = "from_locale";

        private OneSky oneSky;

        internal PluginLanguagePair(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string GetLanguagePairs(string fromLocale)
        {
            return this.oneSky.CreateRequest(GetAddress).Parameter(GetFromLocaleParam, fromLocale).Get();
        }
    }
}