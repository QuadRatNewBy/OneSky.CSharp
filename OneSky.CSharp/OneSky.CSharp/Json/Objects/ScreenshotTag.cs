#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    public class ScreenshotTag : IScreenshotTag
    {
        [JsonProperty("key")]
        private string key;

        [JsonProperty("x")]
        private int x;

        [JsonProperty("y")]
        private int y;

        [JsonProperty("width")]
        private int width;

        [JsonProperty("height")]
        private int height;

        [JsonProperty("file")]
        private string file;

        public ScreenshotTag(string key, int x, int y, int width, int height, string file = null)
        {
            this.key = key;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.file = file;
        }

        public ScreenshotTag(IScreenshotTag tag)
            : this(tag.Key, tag.X, tag.Y, tag.Width, tag.Height, tag.File)
        {
        }

        public string Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public string File
        {
            get
            {
                return this.file;
            }
            set
            {
                this.file = value;
            }
        }
    }
}