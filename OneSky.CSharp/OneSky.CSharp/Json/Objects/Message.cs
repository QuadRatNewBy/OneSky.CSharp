namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal class Message : IMessage
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("content")]
        private string content;

        [JsonProperty("created_at")]
        private DateTime createdAt;

        [JsonProperty("created_at_timestamp")]
        private long createdAtTimestamp;

        [JsonProperty("author")]
        private IPerson author;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
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

        public IPerson Author
        {
            get
            {
                return this.author;
            }
        }
    }
}