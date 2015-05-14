namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class Meta : IMeta
    {
        [JsonProperty("code")]
        protected int? code;

        [JsonProperty("status")]
        protected int? status;

        [JsonProperty("message")]
        protected string message;

        public int Status
        {
            get
            {
                return this.status ?? this.code ?? -1;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}