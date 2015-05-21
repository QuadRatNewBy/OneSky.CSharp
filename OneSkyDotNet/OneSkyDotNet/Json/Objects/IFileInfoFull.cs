namespace OneSkyDotNet.Json
{
    public interface IFileInfoFull : IFileInfo
    {
        IImportTaskCreated Import { get; }
    }
}