namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class ImportTaskStatus : ImportTask, IImportTaskStatus
    {
        [JsonProperty("status")]
        private string status;

        public string Status
        {
            get
            {
                return this.status;
            }
        }
    }
}