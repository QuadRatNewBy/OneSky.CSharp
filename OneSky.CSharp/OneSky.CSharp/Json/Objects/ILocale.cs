namespace OneSkyDotNet.Json
{
    public interface ILocale
    {
        string Code { get; }

        string EnglishName { get; }

        string LocalName { get; }

        string Locale { get; }

        string Region { get; }
    }
}