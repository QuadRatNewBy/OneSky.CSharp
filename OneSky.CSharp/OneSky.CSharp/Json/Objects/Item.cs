#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    public class Item : IItem
    {
        [JsonProperty("title")]
        private string title;

        [JsonProperty("content")]
        private string content;

        public Item(string title = null, string content = null)
        {
            this.title = title;
            this.content = content;
        }

        public Item(IItem item)
            : this(item.Title, item.Content)
        {
        }

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