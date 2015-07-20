#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System;

    using Newtonsoft.Json;

    internal class LocaleProject : LocaleGroup, ILocaleProject
    {
        [JsonProperty("is_ready_to_publish")]
        private bool isReadyToPublish;

        [JsonProperty("translation_progress")]
        private string translationProgress;

        [JsonProperty("uploaded_at")]
        private DateTime uploadedAt;

        [JsonProperty("uploaded_at_timestamp")]
        private long uploadedAtTimestamp;

        public bool IsReadyToPublish { get { return this.isReadyToPublish; } }

        public string TranslationProgress { get { return this.translationProgress; } }

        public DateTime UploadedAt{ get { return this.uploadedAt; } }

        public long UploadedAtTimeStamp { get { return this.uploadedAtTimestamp; } }
    }
}
