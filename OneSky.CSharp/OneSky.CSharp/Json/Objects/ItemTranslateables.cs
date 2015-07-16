namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class ItemTranslateables : ItemContainer, IItemTranslateables
    {
        [JsonProperty("title")]
        private ItemTranslateablesTranslations title;

        [JsonProperty("content")]
        private ItemTranslateablesTranslations content;

        public IDictionary<string, string> Title
        {
            get
            {
                return this.title == null ? null : this.title.Translations;
            }
        }

        public IDictionary<string, string> Content
        {
            get
            {
                return this.content == null ? null : this.content.Translations;
            }
        }
    }
}