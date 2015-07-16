namespace OneSky.CSharp.Json
{
    public interface IOrderPlatformNew : IOrderPlatform
    {
        ILocale ToLanguage { get; }

        bool IsIncludingNotTranslated { get; }

        bool IsIncludingNotApproved { get; }

        bool IsIncludingOutdated { get; }
    }
}