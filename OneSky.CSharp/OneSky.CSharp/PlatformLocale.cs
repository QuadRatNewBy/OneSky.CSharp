namespace OneSky.CSharp
{
    internal class PlatformLocale : IPlatformLocale
    {
        private const string LocaleListAddress = "https://platform.api.onesky.io/1/locales";

        private readonly OneSkyHelper oneSky;

        internal PlatformLocale(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List()
        {
            return this.oneSky.CreateRequest(LocaleListAddress).Get();
        }
    }
}