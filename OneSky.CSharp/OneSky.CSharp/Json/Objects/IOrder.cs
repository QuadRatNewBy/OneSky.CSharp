namespace OneSky.CSharp.Json
{
    using System;

    public interface IOrder
    {
        int Id { get; }

        DateTime OrderedAt { get; }

        long OrderedAtTimestamp { get; }
    }
}