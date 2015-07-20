namespace OneSky.CSharp
{
    internal class PluginLocale : IPluginLocale
    {
        private const string GetLocaleAddress = "https://plugin.api.onesky.io/1/locales";

        private OneSkyHelper oneSky;

        internal PluginLocale(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetLocales()
        {
            return this.oneSky.CreateRequest(GetLocaleAddress).Get();
        }
    }
}