#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class OrderPlatformNew : OrderPlatform, IOrderPlatformNew
    {
        [JsonProperty("to_language")]
        private Localeo toLanguage;

        [JsonProperty("is_including_not_translated")]
        private bool isIncludingNotTranslated;

        [JsonProperty("is_including_not_approved")]
        private bool isIncludingNotApproved;

        [JsonProperty("is_including_outdated")]
        private bool isIncludingOutdated;

        public ILocale ToLanguage
        {
            get
            {
                return this.toLanguage;
            }
        }

        public bool IsIncludingNotTranslated
        {
            get
            {
                return this.isIncludingNotTranslated;
            }
        }

        public bool IsIncludingNotApproved
        {
            get
            {
                return this.isIncludingNotApproved;
            }
        }

        public bool IsIncludingOutdated
        {
            get
            {
                return this.isIncludingOutdated;
            }
        }
    }
}