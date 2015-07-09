namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    public class OrderTask : IOrderTask
    {
        [JsonProperty("status")]
        private string status;

        [JsonProperty("completed_at")]
        private DateTime? completedAt;

        [JsonProperty("completed_at_timestamp")]
        private long? completedAtTimestamp;

        [JsonProperty("translator")]
        private Person translator;

        [JsonProperty("to_language")]
        private Localeo toLanguage;

        public string Status
        {
            get
            {
                return this.status;
            }
        }

        public DateTime CompletedAt
        {
            get
            {
                return this.completedAt ?? default(DateTime);
            }
        }

        public long CompletedAtTimestamp
        {
            get
            {
                return this.completedAtTimestamp ?? default(long);
            }
        }

        public IPerson Translator
        {
            get
            {
                return this.translator;
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