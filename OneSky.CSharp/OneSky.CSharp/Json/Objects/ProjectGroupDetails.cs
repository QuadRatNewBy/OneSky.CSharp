namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class ProjectGroupDetails : ProjectGroup, IProjectGroupDetails
    {
        [JsonProperty("enabled_language_count")]
        private int enabledLanguageCount;

        [JsonProperty("project_count")]
        private int projectCount;

        public int EnabledLanguageCount
        {
            get
            {
                return this.enabledLanguageCount;
            }
        }

        public int ProjectCount
        {
            get
            {
                return this.projectCount;
            }
        }
    }
}