namespace OneSkyDotNet.Json
{
    using System;

    public interface IQuotationDetails
    {
        float PerWordCost { get; }

        float TotalCost { get; }

        DateTime WillCompleteAt { get; }

        long WillCompleteAtTimestamp { get; }

        int SecondsToComplete { get; }
    }
}