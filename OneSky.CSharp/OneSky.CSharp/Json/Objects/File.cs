#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class File : IFile
    {
        [JsonProperty("name")]
        private string name;

        [JsonProperty("file_name")]
        private string fileName;

        public string Name
        {
            get
            {
                return this.name ?? this.fileName;
            }
        }
    }
}