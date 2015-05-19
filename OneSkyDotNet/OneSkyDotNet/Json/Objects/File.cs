namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class File : IFile
    {
        [JsonProperty("file")]
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}