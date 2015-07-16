namespace OneSky.CSharp
{
    public interface IPluginLanguagePair
    {
        IOneSkyResponse GetLanguagePairs(string fromLocale);
    }
}