namespace OneSky.CSharp.Json
{
    public interface ILocaleGroup : ILocale
    {
        bool IsBaseLanguage { get; }
    }
}