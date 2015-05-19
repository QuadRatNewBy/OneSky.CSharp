namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class Item : IItem
    {
        [JsonProperty("title")]
        private string title;

        [JsonProperty("content")]
        private string content;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                this.content = value;
            }
        }
    }
}