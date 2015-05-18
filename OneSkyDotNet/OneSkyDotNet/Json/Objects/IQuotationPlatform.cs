namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IQuotationPlatform : IQuotation
    {
        IEnumerable<IFile> Files { get; }

        bool IsIncludingNotTranslated { get; }

        bool IsIncludingNotApproved { get; }

        bool IsIncludingOutdated { get; }

        string Specialization { get; }

        IQuotationDetailsFull TranslationOnly { get; }

        IQuotationDetailsFull TranslationAndReview { get; }

        IQuotationDetailsFull ReviewOnly { get; }
    }
}