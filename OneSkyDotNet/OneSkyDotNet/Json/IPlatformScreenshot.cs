namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPlatformScreenshot
    {
        IOneSkyResponse<IMeta, INull> Upload(int projectId, IEnumerable<IScreenshot> screenshots);
    }
}