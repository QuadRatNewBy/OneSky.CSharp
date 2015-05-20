namespace OneSkyDotNet.Json
{
    public interface IImportTaskFileInfo : IImportTaskStatus, IImportTaskCreated
    {
        IFileInfo File { get; }
    }
}