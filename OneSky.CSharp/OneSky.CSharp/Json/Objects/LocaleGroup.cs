namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class LocaleGroup : Localeo, ILocaleGroup
    {
        [JsonProperty("is_base_language")]
        private bool isBaseLanguage;

        public bool IsBaseLanguage
        {
            get
            {
                return this.isBaseLanguage;
            }
        }
    }
}