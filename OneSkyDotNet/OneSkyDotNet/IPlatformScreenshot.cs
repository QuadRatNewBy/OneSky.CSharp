namespace OneSkyDotNet
{
    using System.Collections.Generic;

    public interface IPlatformScreenshot
    {
        string Upload(int projectId, IEnumerable<string> screenshots);
    }
}