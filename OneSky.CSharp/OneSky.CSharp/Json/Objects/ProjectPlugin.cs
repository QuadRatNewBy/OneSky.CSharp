#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class ProjectPlugin : Project, IProjectPlugin
    {
        [JsonProperty("platform")]
        private string platform;

        [JsonProperty("base_language")]
        private Localeo baseLanguage;

        public string Platform { get { return this.platform; } }

        public ILocale BaseLanguage { get { return this.baseLanguage; } }
    }
}
