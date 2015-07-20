#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class ImportTask : IImportTask
    {
        [JsonProperty("id")]
        private int id;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}