namespace OneSkyDotNet.Json
{
    public interface IOrderTaskBase
    {
        int Id { get; }

        ILocale FromLanguage { get; }

        ILocale ToLanguage { get; }
    }
}