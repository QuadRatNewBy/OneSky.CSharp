namespace OneSkyDotNet
{
    internal class PlatformPlainLocale : IPlatformPlainLocale
    {
        private const string LocaleListAddress = "https://platform.api.onesky.io/1/locales";

        private OneSky oneSky;

        internal PlatformPlainLocale(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string List()
        {
            return this.oneSky.CreateRequest(LocaleListAddress).Get();
        }
    }
}