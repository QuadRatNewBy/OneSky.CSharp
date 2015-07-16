namespace OneSkyDotNet.Json
{
    public interface IImportTaskStatus : IImportTask
    {
        string Status { get; }
    }
}