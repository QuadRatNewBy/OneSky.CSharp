namespace OneSkyDotNet.Json
{
    public interface IImportTaskFile : IImportTaskStatus, IImportTaskCreated
    {
        IFile File { get; }
    }
}