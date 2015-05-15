namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class LocaleProject : LocaleGroup, ILocaleProject
    {
        [JsonProperty("is_ready_to_publish")]
        private bool isReadyToPublish;

        [JsonProperty("translation_progress")]
        private string translationProgress;

        public bool IsReadyToPublish { get { return this.isReadyToPublish; } }

        public string TranslationProgress { get { return this.translationProgress; } }
    }
}
