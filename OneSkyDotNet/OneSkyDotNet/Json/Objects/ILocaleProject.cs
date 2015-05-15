namespace OneSkyDotNet.Json
{
    public interface ILocaleProject : ILocaleGroup
    {        
        bool IsReadyToPublish { get; }
        
        string TranslationProgress { get; }
    }
}