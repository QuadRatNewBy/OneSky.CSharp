#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class OrderTaskDetails : OrderTask, IOrderTaskDetails
    {
        [JsonProperty("id")]
        private int id;

        [JsonProperty("from_language")]
        private Localeo fromLanguage;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public ILocale FromLanguage
        {
            get
            {
                return this.fromLanguage;
            }
        }
    }
}