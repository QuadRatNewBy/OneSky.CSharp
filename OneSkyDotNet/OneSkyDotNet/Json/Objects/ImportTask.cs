namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class ImportTask : IImportTask
    {
        [JsonProperty("id")]
        private int id;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}