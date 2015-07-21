#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;

    public class Screenshot : IScreenshot
    {
        #region Static

        private static readonly Dictionary<string, string> MimeTypes;

        private static readonly string DataSchema = "data:image/{0};base64,{1}";

        private static Func<string, string> staticImagePathToBase64;

        private static Func<string, string> staticImagePathToImageType;

        static Screenshot()
        {
            MimeTypes = new Dictionary<string, string>
                            {
                                { ".gif", "gif" },
                                { ".jpg", "jpeg" },
                                { ".jpe", "jpeg" },
                                { ".jpeg", "jpeg" },
                                { ".png", "png" },
                                { ".svg", "svg+xml" },
                                { ".svgz", "svg+xml" },
                                { ".tif", "tiff" },
                                { ".tiff", "tiff" },
                                { ".ico", "vnd.microsoft.icon" },
                                { ".wbmp", "vnd.wap.wbmp" },
                                { ".bmp", "bmp" },
                                { ".dib", "bmp" },
                                { ".rle", "bmp" }
                            };
        }

        private static string DefaultImagePathToImageType(string path)
        {
            var ext = Path.GetExtension(path) ?? string.Empty;
            string mime;
            return MimeTypes.TryGetValue(ext, out mime) ? mime : ext.Substring(1);
        }

        private static string DefaultImagePathToBase64(string path)
        {
            var base64String = Convert.ToBase64String(System.IO.File.ReadAllBytes(path));
            return base64String;
        }

        public static Func<string, string> ImagePathToBase64
        {
            get
            {
                return staticImagePathToBase64 ?? DefaultImagePathToBase64;
            }
            set
            {
                staticImagePathToBase64 = value;
            }
        }

        public static Func<string, string> ImagePathToImageType
        {
            get
            {
                return staticImagePathToImageType ?? DefaultImagePathToImageType;
            }
            set
            {
                staticImagePathToImageType = value;
            }
        }
        #endregion Static

        [JsonProperty("name")]
        private string name;

        [JsonProperty("image")]
        private string image;

        [JsonIgnore]
        private string imagePath;

        [JsonProperty("tags")]
        private List<IScreenshotTag> tags;

        private Screenshot(IEnumerable<IScreenshotTag> tags)
        {
            this.tags = new List<IScreenshotTag>();
            this.tags.AddRange(tags.Select(x => new ScreenshotTag(x)));
        }

        public Screenshot(string name, string image, IEnumerable<IScreenshotTag> tags)
            : this(tags)
        {
            this.name = name;
            this.image = image;
        }

        public Screenshot(string path, IEnumerable<IScreenshotTag> tags)
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
                this.image = string.Format(DataSchema, ImagePathToImageType(value), ImagePathToBase64(value));
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