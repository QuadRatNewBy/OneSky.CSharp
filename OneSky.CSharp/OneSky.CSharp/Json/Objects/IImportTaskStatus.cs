namespace OneSky.CSharp.Json
{
    public interface IImportTaskStatus : IImportTask
    {
        string Status { get; }
    }
}