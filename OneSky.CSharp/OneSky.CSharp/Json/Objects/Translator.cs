namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal class Translator : ITranslator
    {
        [JsonProperty("will_complete_at")]
        private DateTime willCompleteAt;

        [JsonProperty("will_complete_at_timestamp")]
        private long willCompleteAtTimestamp;

        [JsonProperty("seconds_to_complete")]
        private int secondsToComplete;

        public DateTime WillCompleteAt
        {
            get
            {
                return this.willCompleteAt;
            }
        }

        public long WillCompleteAtTimestamp
        {
            get
            {
                return this.willCompleteAtTimestamp;
            }
        }

        public int SecondsToComplete
        {
            get
            {
                return this.secondsToComplete;
            }
        }
    }
}