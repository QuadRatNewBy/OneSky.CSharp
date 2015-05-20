namespace OneSkyDotNet.Json
{
    using System;

    public interface IImportTaskCreated : IImportTask
    {
         DateTime CreatedAt { get; }
         long CreatedAtTimestamp { get; }
    }
}