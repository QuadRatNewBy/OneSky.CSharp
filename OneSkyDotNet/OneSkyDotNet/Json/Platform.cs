namespace OneSkyDotNet.Json
{
    internal class Platform : IPlatform
    {
        public IPlatformLocale Locale { get; private set; }

        public IPlatformProjectType ProjectType { get; private set; }

        internal Platform(OneSkyDotNet.IPlatform platform)
        {
            this.Locale = new PlatformLocale(platform.Locale);
            this.ProjectType = new PlatformProjectType(platform.ProjectType);
        }
    }
}