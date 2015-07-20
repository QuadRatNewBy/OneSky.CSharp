#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class Project : IProject
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("name")]
        private string name;

        public int Id { get { return this.id; } }

        public string Name { get { return this.name; } }
    }
}
