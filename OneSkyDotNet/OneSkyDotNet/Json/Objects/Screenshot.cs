namespace OneSkyDotNet.Json
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;

    public class Screenshot : IScreenshot
    {
        private static string ToBase64(string path)
        {
            using (var image = System.Drawing.Image.FromFile(path))
            {
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, image.RawFormat);
                    var imageBytes = memoryStream.ToArray();

                    var base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private static readonly string DataSchema = "data:image/{0};base64,{1}";

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
                this.name = Path.GetFileName(value);
                this.image = string.Format(
                    DataSchema,
                    (Path.GetExtension(value) ?? string.Empty).Replace(".", string.Empty),
                    ToBase64(value));
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