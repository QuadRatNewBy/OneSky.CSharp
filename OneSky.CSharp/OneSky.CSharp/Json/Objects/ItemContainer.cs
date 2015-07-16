namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal class ItemContainer : IItemContainer
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("code")]
        private string code;

        [JsonProperty("created_at")]
        private DateTime createdAt;

        [JsonProperty("created_at_timestamp")]
        private long createdAtTimestamp;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Code
        {
            get
            {
                return this.code;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return this.createdAt;
            }
        }

        public long CreatedAtTimestamp
        {
            get
            {
                return this.createdAtTimestamp;
            }
        }
    }
}