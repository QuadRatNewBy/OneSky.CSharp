namespace OneSkyDotNet.Json
{
    public interface ILocaleGroup : ILocale
    {
        bool IsBaseLanguage { get; }
    }
}