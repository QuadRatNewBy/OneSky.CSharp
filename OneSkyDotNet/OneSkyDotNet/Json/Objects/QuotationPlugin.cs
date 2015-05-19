namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class QuotationPlugin : Quotation, IQuotationPlugin
    {
        [JsonProperty("words")]
        private int words;

        [JsonProperty("translation")]
        private QuotationDetails translation;

        [JsonProperty("translation_and_review")]
        private QuotationDetails translationAndReview;

        public int Words
        {
            get
            {
                return this.words;
            }
        }

        public IQuotationDetails Translation
        {
            get
            {
                return this.translation;
            }
        }

        public IQuotationDetails TranslationAndReview
        {
            get
            {
                return this.translationAndReview;
            }
        }
    }
}