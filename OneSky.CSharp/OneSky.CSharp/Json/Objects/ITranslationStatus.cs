namespace OneSky.CSharp.Json
{
    public interface ITranslationStatus
    {
        string FileName { get; }

        ILocale Locale { get; }

        string Progress { get; }

        int StringCount { get; }

        int WordCount { get; }
    }
}
