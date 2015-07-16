namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class FileInfoFull : FileInfo, IFileInfoFull
    {
        [JsonProperty("import")]
        private ImportTaskCreated import;

        public IImportTaskCreated Import
        {
            get
            {
                return this.import;
            }
        }
    }
}