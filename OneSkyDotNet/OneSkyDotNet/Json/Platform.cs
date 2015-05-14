namespace OneSkyDotNet.Json
{
    internal class Platform : IPlatform
    {
        public IPlatformLocale Locale { get; private set; }

        internal Platform(OneSkyDotNet.IPlatform platform)
        {
            this.Locale = new PlatformLocale(platform.Locale);
        }
    }
}