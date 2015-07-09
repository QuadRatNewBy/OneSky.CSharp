namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal class Order : IOrder
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("ordered_at")]
        private DateTime orderedAt;

        [JsonProperty("ordered_at_timestamp")]
        private long orderedAtTimestamp;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public DateTime OrderedAt
        {
            get
            {
                return this.orderedAt;
            }
        }

        public long OrderedAtTimestamp
        {
            get
            {
                return this.orderedAtTimestamp;
            }
        }
    }
}