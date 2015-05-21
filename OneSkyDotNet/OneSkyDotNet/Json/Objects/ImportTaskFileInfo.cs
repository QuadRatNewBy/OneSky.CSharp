namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class ImportTaskFileInfo : ImportTaskCreated, IImportTaskFileInfo
    {
        [JsonProperty("status")]
        private string status;

        [JsonProperty("file")]
        private FileInfo file;

        public string Status
        {
            get
            {
                return this.status;
            }
        }

        public IFileInfo File
        {
            get
            {
                return this.file;
            }
        }
    }
}