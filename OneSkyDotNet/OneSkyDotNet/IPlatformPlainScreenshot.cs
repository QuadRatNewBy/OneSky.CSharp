namespace OneSkyDotNet
{
    using System.Collections.Generic;

    public interface IPlatformPlainScreenshot
    {
        string Upload(int projectId, IEnumerable<string> screenshots);
    }
}