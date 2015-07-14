namespace OneSkyDotNet.Json
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class Screenshot : IScreenshot
    {
        [JsonProperty("name")]
        private string name;
        [JsonProperty("image")]
        private string image;

        [JsonIgnore]
        private string imagePath;

        [JsonProperty("tags")]
        private IList<IScreenshotTag> tags;

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