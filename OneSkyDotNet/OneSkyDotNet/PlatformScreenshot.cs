namespace OneSkyDotNet
{
    using System.Collections.Generic;

    internal class PlatformScreenshot : IPlatformScreenshot
    {
        private const string ScreenshotUploadAddress = "https://platform.api.onesky.io/1/projects/:project_id/screenshots";

        private const string ScreenshotUploadScreenshotsBody = "screenshots";

        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PlatformScreenshot(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse Upload(int projectId, IEnumerable<string> screenshots)
        {
            return
                this.oneSky.CreateRequest(ScreenshotUploadAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Body(ScreenshotUploadScreenshotsBody, screenshots)
                    .Post();
        }
    }
}