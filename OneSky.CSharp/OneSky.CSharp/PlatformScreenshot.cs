namespace OneSky.CSharp
{
    using System.Collections.Generic;

    internal class PlatformScreenshot : IPlatformScreenshot
    {
        private const string ScreenshotUploadAddress =
            "https://platform.api.onesky.io/1/projects/{project_id}/screenshots";

        private const string ScreenshotUploadScreenshotsBody = "screenshots";

        private const string ProjectIdPlaceholder = "project_id";

        private OneSkyHelper oneSky;

        internal PlatformScreenshot(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse Upload(int projectId, IEnumerable<string> screenshots)
        {
            return
                this.oneSky.CreateRequest(ScreenshotUploadAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Body(ScreenshotUploadScreenshotsBody, screenshots)
                    .Post();
        }
    }
}