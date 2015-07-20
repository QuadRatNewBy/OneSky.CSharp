#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class Quotation : IQuotation
    {
        [JsonProperty("from_language")]
        private Localeo fromLanguage;

        [JsonProperty("to_language")]
        private Localeo toLanguage;

        public ILocale FromLanguage
        {
            get
            {
                return this.fromLanguage;
            }
        }

        public ILocale ToLanguage
        {
            get
            {
                return this.toLanguage;
            }
        }
    }
}