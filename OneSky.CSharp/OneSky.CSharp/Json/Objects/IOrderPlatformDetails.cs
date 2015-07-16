namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IOrderPlatformDetails : IOrderPlatform
    {
        string Status { get; }

        decimal Amount { get; }

        IEnumerable<IOrderTaskFullDetails> Tasks { get; }
    }
}