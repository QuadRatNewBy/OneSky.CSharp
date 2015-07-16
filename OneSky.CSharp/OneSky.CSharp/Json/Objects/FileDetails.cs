namespace OneSky.CSharp.Json
{
    using System;

    using Newtonsoft.Json;

    internal class FileDetails : File, IFileDetails
    {
        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("last_import")]
        private ImportTaskStatus lastImport;

        [JsonProperty("uploaded_at")]
        private DateTime? uploadedAt;

        [JsonProperty("uploaded_at_timestamp")]
        private long? uploadedAtTimestamp;

        public int StringCount
        {
            get
            {
                return this.stringCount;
            }
        }

        public IImportTaskStatus LastImport
        {
            get
            {
                return this.lastImport;
            }
        }

        public DateTime UploadedAt
        {
            get
            {
                return this.uploadedAt ?? default(DateTime);
            }
        }

        public long UploadedAtTimestamp
        {
            get
            {
                return this.uploadedAtTimestamp ?? default(long);
            }
        }
    }
}