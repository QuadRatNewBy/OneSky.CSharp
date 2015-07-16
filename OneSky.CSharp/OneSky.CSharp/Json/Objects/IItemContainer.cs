namespace OneSky.CSharp.Json
{
    using System;

    public interface IItemContainer
    {
        int Id { get; }

        string Code { get; }

        DateTime CreatedAt { get; }

        long CreatedAtTimestamp { get; }
    }
}