namespace OneSky.CSharp.Json
{
    public interface IQuotationPlugin : IQuotation
    {
        int Words { get; }

        IQuotationDetails Translation { get; }

        IQuotationDetails TranslationAndReview { get; }
    }
}