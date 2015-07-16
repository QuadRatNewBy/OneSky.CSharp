namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class OrderTaskBase : IOrderTaskBase
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("from_language")]
        private Localeo fromLanguage;

        [JsonProperty("to_language")]
        private Localeo toLanguage;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

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