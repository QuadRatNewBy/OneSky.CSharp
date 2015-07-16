namespace OneSkyDotNet.Json
{
    public interface IScreenshotTag
    {
        string Key { get; set; }

        int X { get; set; }

        int Y { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        string File { get; set; }
    }
}