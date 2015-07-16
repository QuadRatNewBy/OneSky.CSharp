namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IScreenshot
    {
        string Name { get; set; }

        string Image { get; }

        string ImagePath { get; set; }

        IList<IScreenshotTag> Tags { get; }
    }
}