namespace OneSky.CSharp.Json
{
    using System;

    public interface IFileDetails : IFile
    {
        int StringCount { get; }

        IImportTaskStatus LastImport { get; }

        DateTime UploadedAt { get; }

        long UploadedAtTimestamp { get; }
    }
}