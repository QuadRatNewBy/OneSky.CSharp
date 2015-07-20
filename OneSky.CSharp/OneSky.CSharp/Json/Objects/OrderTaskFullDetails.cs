#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System;

    using Newtonsoft.Json;

    internal class OrderTaskFullDetails : OrderTask, IOrderTaskFullDetails
    {
        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("word_count")]
        private int wordCount;

        [JsonProperty("will_complete_at")]
        private DateTime? willCompleteAt;

        [JsonProperty("will_complete_at_timestamp")]
        private long? willCompleteAtTimestamp;

        [JsonProperty("seconds_to_complete")]
        private int secondsToComplete;

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

        public DateTime WillCompleteAt
        {
            get
            {
                return this.willCompleteAt ?? default(DateTime);
            }
        }

        public long WillCompleteAtTimestamp
        {
            get
            {
                return this.willCompleteAtTimestamp ?? default(long);
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