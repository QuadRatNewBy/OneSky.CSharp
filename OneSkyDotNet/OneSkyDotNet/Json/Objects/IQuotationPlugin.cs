namespace OneSkyDotNet.Json
{
    public interface IQuotationPlugin : IQuotation
    {
        int Words { get; }

        IQuotationDetails Translation { get; }

        IQuotationDetails TranslationAndReview { get; }
    }
}