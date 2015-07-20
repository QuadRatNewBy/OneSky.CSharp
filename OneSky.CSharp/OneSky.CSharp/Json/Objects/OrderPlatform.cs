#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderPlatform : Order, IOrderPlatform
    {
        [JsonProperty("files")]
        private IEnumerable<File> files;

        [JsonProperty("from_language")]
        private Localeo fromLanguage;

        [JsonProperty("order_type")]
        private string orderType;

        [JsonProperty("tone")]
        private string tone;

        [JsonProperty("specialization")]
        private string specialization;

        [JsonProperty("note")]
        private string note;

        public IEnumerable<IFile> Files
        {
            get
            {
                return this.files;
            }
        }

        public ILocale FromLanguage
        {
            get
            {
                return this.fromLanguage;
            }
        }

        public string OrderType
        {
            get
            {
                return this.orderType;
            }
        }

        public string Tone
        {
            get
            {
                return this.tone;
            }
        }

        public string Specialization
        {
            get
            {
                return this.specialization;
            }
        }

        public string Note
        {
            get
            {
                return this.note;
            }
        }
    }
}