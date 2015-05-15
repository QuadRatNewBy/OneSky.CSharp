namespace OneSkyDotNet.Json
{
    public interface IProjectDetails : IProjectNew
    {
        int StringCount { get; }

        int WordCount { get; }
    }
}
