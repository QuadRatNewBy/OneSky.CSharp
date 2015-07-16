namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IOrderPlatform : IOrder
    {
        IEnumerable<IFile> Files { get; }

        ILocale FromLanguage { get; }

        string OrderType { get; }

        string Tone { get; }

        string Specialization { get; }

        string Note { get; }
    }
}