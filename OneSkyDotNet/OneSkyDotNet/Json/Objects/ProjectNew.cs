namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class ProjectNew : Project, IProjectNew
    {
        [JsonProperty("project_type")]
        private ProjectType projectType;

        [JsonProperty("description")]
        private string description;

        public IProjectType ProjectType { get { return this.projectType; } }

        public string Description { get { return this.description; } }
    }
}
