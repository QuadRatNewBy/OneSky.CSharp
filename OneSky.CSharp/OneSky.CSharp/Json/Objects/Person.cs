#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class Person : IPerson
    {
        [JsonProperty("name")]
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