namespace OneSky.CSharp.Json
{
    using System;

    public interface IQuotationDetails
    {
        decimal PerWordCost { get; }

        decimal TotalCost { get; }

        DateTime WillCompleteAt { get; }

        long WillCompleteAtTimestamp { get; }

        int SecondsToComplete { get; }
    }
}