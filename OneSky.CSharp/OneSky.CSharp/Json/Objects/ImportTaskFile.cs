namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class ImportTaskFile : ImportTaskCreated, IImportTaskFile
    {
        [JsonProperty("status")]
        private string status;

        [JsonProperty("file")]
        private File file;

        public string Status
        {
            get
            {
                return this.status;
            }
        }

        public IFile File
        {
            get
            {
                return this.file;
            }
        }
    }
}