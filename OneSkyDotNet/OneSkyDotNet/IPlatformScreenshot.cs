namespace OneSkyDotNet
{
    using System.Collections.Generic;

    public interface IPlatformScreenshot
    {
        IOneSkyResponse Upload(int projectId, IEnumerable<string> screenshots);
    }
}