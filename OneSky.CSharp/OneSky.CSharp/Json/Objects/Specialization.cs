namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class Specialization : ISpecialization
    {
        [JsonProperty("code")]
        private string code;

        [JsonProperty("name")]
        private string name;

        public string Code
        {
            get
            {
                return this.code;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}