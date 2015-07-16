namespace OneSky.CSharp.Json
{
    using System;

    public interface IOrderTask
    {
        string Status { get; }

        DateTime CompletedAt { get; }

        long CompletedAtTimestamp { get; }

        IPerson Translator { get; }

        ILocale ToLanguage { get; }
    }
}