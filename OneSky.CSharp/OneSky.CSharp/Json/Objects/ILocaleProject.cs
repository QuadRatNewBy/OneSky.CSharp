namespace OneSky.CSharp.Json
{
    using System;

    public interface ILocaleProject : ILocaleGroup
    {        
        bool IsReadyToPublish { get; }
        
        string TranslationProgress { get; }

        DateTime UploadedAt { get; }

        long UploadedAtTimeStamp { get; }
    }
}