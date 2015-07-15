namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    public class PlatformScreenshot : IPlatformScreenshot
    {
        private OneSkyDotNet.IPlatformScreenshot screenshot;

        public PlatformScreenshot(OneSkyDotNet.IPlatformScreenshot screenshot)
        {
            this.screenshot = screenshot;
        }

        public IOneSkyResponse<IMeta, INull> Upload(int projectId, IEnumerable<IScreenshot> screenshots)
        {
            var plainScreenshots = screenshots.Select(JsonConvert.SerializeObject);
            var plain = this.screenshot.Upload(projectId, plainScreenshots);
            return JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
        }
    }
}