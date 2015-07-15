namespace OneSkyDotNet.Json
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    public class Screenshot : IScreenshot
    {
        [JsonProperty("name")]
        private string name;
        [JsonProperty("image")]
        private string image;

        [JsonIgnore]
        private string imagePath;

        [JsonProperty("tags")]
        private List<IScreenshotTag> tags;

        private Screenshot(IList<IScreenshotTag> tags)
        {
            this.tags = new List<IScreenshotTag>();
            this.tags.AddRange(tags.Select(x => new ScreenshotTag(x)));
        }

        public Screenshot(string name, string image, IList<IScreenshotTag> tags)
            : this(tags)
        {
            this.name = name;
            this.image = image;
        }

        public Screenshot(string path, IList<IScreenshotTag> tags)
            : this(tags)
        {
            this.ImagePath = path;
        }

        public Screenshot(IScreenshot screenshot)
            : this(screenshot.Name, screenshot.Image, screenshot.Tags)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Image
        {
            get
            {
                return this.image;
            }
        }

        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                this.imagePath = value;
                throw new NotImplementedException("Recalcutation of Base64 required.");
            }
        }

        public IList<IScreenshotTag> Tags
        {
            get
            {
                return this.tags;
            }
        }
    }
}