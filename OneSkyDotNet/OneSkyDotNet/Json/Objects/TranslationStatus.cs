namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class TranslationStatus : ITranslationStatus
    {
        [JsonProperty("file_name")]
        private string fileName;

        [JsonProperty("locale")]
        private Localeo locale;

        [JsonProperty("progress")]
        private string progress;

        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("word_count")]
        private int wordCount;

        public string FileName
        {
            get
            {
                return this.fileName;
            }
        }

        public ILocale Locale
        {
            get
            {
                return this.locale;
            }
        }

        public string Progress
        {
            get
            {
                return this.progress;
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
