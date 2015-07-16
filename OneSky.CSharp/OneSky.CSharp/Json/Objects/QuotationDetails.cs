namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal class QuotationDetails : IQuotationDetails
    {
        [JsonProperty("per_word_cost")]
        private float perWordCost;

        [JsonProperty("total_cost")]
        private float totalCost;

        [JsonProperty("will_complete_at")]
        private DateTime? willCompleteAt;

        [JsonProperty("will_complete_at_timestamp")]
        private long? willCompleteAtTimestamp;

        [JsonProperty("seconds_to_complete")]
        private int? secondsToComplete;

        [JsonProperty("estimated_return_datetime")]
        private DateTime? estimatedReturnDatetime;

        [JsonProperty("estimated_return_timestamp")]
        private long? estimatedReturnTimestamp;

        [JsonProperty("estimated_seconds_from_now")]
        private int? estimatedSecondsFromNow;

        public float PerWordCost
        {
            get
            {
                return this.perWordCost;
            }
        }

        public float TotalCost
        {
            get
            {
                return this.totalCost;
            }
        }

        public DateTime WillCompleteAt
        {
            get
            {
                return this.willCompleteAt ?? this.estimatedReturnDatetime ?? default(DateTime);
            }
        }

        public long WillCompleteAtTimestamp
        {
            get
            {
                return this.willCompleteAtTimestamp ?? this.estimatedReturnTimestamp ?? default(long);
            }
        }

        public int SecondsToComplete
        {
            get
            {
                return this.secondsToComplete ?? this.estimatedSecondsFromNow ?? default(int);
            }
        }
    }
}