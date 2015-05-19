namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    public class Item : IItem
    {
        [JsonProperty("title")]
        private string title;

        [JsonProperty("content")]
        private string content;

        [JsonIgnore]
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

        [JsonIgnore]
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