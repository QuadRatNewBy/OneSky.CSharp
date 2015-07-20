#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class QuotationDetailsFull : QuotationDetails, IQuotationDetailsFull
    {
        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("word_count")]
        private int wordCount;

        [JsonProperty("preferred_translator")]
        private Translator preferredTranslator;

        public int StringCount
        {
            get
            {
                return this.stringCount;
            }
        }

        public int WordCount
        {
            get
            {
                return this.wordCount;
            }
        }

        public ITranslator PreferredTranslator
        {
            get
            {
                return this.preferredTranslator;
            }
        }
    }
}