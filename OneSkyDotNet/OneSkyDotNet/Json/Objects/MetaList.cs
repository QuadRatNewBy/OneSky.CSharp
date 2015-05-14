namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class MetaList : Meta, IMetaList
    {
        [JsonProperty("record_count")]
        protected int recordCount;

        public int RecordCount
        {
            get
            {
                return this.recordCount;
            }
        }
    }
}