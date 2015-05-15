namespace OneSkyDotNet.Json
{
    public interface IPlatform
    {
        IPlatformLocale Locale { get; }

        IPlatformProjectType ProjectType { get; }

        IPlatformProjectGroup ProjectGroup { get; }
    }
}