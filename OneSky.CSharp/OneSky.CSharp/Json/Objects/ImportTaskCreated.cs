#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System;

    using Newtonsoft.Json;

    internal class ImportTaskCreated : ImportTask, IImportTaskCreated
    {
        [JsonProperty("created_at")]
        private DateTime createdAt;

        [JsonProperty("created_at_timestamp")]
        private long createdAtTimestamp;

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