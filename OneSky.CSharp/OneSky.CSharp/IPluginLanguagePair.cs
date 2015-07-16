namespace OneSkyDotNet
{
    public interface IPluginLanguagePair
    {
        IOneSkyResponse GetLanguagePairs(string fromLocale);
    }
}