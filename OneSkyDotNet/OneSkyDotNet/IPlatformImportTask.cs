﻿namespace OneSkyDotNet
{
    public interface IPlatformImportTask
    {

        string List(int projectId, int page = 1, int perPage = 50, string status = "all");

        string Show(int projectId, int importTaskId);
    }
}