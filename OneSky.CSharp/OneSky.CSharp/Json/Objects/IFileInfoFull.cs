namespace OneSky.CSharp.Json
{
    public interface IFileInfoFull : IFileInfo
    {
        IImportTaskCreated Import { get; }
    }
}