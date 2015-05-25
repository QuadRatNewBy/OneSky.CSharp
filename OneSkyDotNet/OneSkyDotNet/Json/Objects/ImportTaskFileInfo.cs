namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class ImportTaskFileInfo : ImportTaskCreated, IImportTaskFileInfo
    {
        [JsonProperty("status")]
        private string status;

        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("word_count")]
        private int wordCount;

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

        public int StringCount
        {
            get
            {
                return this.stringCount;
            }
        }

        public int WordCount
        {
            get
            {
                return this.wordCount;
            }
        }
    }
}