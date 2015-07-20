#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class Localeo : ILocale
    {
        [JsonProperty("code")]
        private string code;

        [JsonProperty("english_name")]
        private string englishName;

        [JsonProperty("local_name")]
        private string localName;

        [JsonProperty("locale")]
        private string locale;

        [JsonProperty("region")]
        private string region;

        public string Code
        {
            get
            {
                return this.code;
            }
        }

        public string EnglishName
        {
            get
            {
                return this.englishName;
            }
        }

        public string LocalName
        {
            get
            {
                return this.localName;
            }
        }

        public string Locale
        {
            get
            {
                return this.locale;
            }
        }

        public string Region
        {
            get
            {
                return this.region;
            }
        }
    }
}