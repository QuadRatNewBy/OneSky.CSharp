namespace OneSkyDotNet.Json
{
    public interface IOrderPlatformNew : IOrderPlatform
    {
        ILocale ToLanguage { get; }

        bool IsIncludingNotTranslated { get; }

        bool IsIncludingNotApproved { get; }

        bool IsIncludingOutdated { get; }
    }
}