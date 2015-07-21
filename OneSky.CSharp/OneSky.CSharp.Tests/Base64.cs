namespace OneSky.CSharp.Tests
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    using FluentAssertions;

    using Xunit;

    public class Base64
    {
        private static string ImageToBase64(string path)
        {
            using (var image = Image.FromFile(path))
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

        private static string FileToBase64(string path)
        {
            var base64String = Convert.ToBase64String(File.ReadAllBytes(path));
            return base64String;
        }

        [Theory]
        [InlineData("Base64/cross.bmp")]
        [InlineData("Base64/cross.tif")]
        public void ImageAndFileEquality(string filePath)
        {
            var imageBase64 = ImageToBase64(filePath);
            var fileBase64 = FileToBase64(filePath);
            imageBase64.Should().Be(fileBase64);
            fileBase64.Should().Be(imageBase64);
        }

        [Theory]
        [InlineData("Base64/cross.jpg")]
        [InlineData("Base64/cross.png")]
        public void ImageAndFileSimilarity(string filePath)
        {
            var imageBase64 = ImageToBase64(filePath);
            var fileBase64 = FileToBase64(filePath);
            var comparison = imageBase64.Zip(fileBase64, (f, s) => f == s).ToList();
            var similarity = (100.0 * comparison.Count(x => x)) / comparison.Count;
            similarity.Should().BeGreaterThan(90);
        }

        [Theory]
        [InlineData("Base64/cross.gif")]
        public void ImageAndFileDifference(string filePath)
        {
            var imageBase64 = ImageToBase64(filePath);
            var fileBase64 = FileToBase64(filePath);
            var difference = imageBase64.Length - fileBase64.Length;
            difference.Should().BePositive();
        }
    }
}