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