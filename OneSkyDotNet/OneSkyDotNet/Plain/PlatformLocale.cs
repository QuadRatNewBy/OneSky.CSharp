namespace OneSkyDotNet
{
    internal class PlatformLocale : IPlatformPlainLocale
    {
        private const string LocaleListAddress = "https://platform.api.onesky.io/1/locales";

        private OneSky oneSky;

        public PlatformLocale(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string List()
        {
            return this.oneSky.CreateRequest(LocaleListAddress).Get();
        }
    }
}