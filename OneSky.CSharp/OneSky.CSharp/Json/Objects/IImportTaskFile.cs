namespace OneSky.CSharp.Json
{
    public interface IImportTaskFile : IImportTaskStatus, IImportTaskCreated
    {
        IFile File { get; }
    }
}