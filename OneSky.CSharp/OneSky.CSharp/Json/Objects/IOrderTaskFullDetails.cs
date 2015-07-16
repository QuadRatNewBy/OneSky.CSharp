namespace OneSkyDotNet.Json
{
    using System;

    public interface IOrderTaskFullDetails : IOrderTask
    {
        int StringCount { get; }

        int WordCount { get; }

        DateTime WillCompleteAt { get; }

        long WillCompleteAtTimestamp { get; }

        int SecondsToComplete { get; }
    }
}