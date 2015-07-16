namespace OneSky.CSharp.Json
{
    public interface IQuotation
    {
        ILocale FromLanguage { get; }

        ILocale ToLanguage { get; }
    }
}