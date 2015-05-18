namespace OneSkyDotNet.Json
{
    public interface IQuotation
    {
        ILocale FromLanguage { get; }

        ILocale ToLanguage { get; }
    }
}