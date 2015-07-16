namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class MetaList : Meta, IMetaList
    {
        [JsonProperty("record_count")]
        private int recordCount;

        public int RecordCount
        {
            get
            {
                return this.recordCount;
            }
        }
    }
}