namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class Meta : IMeta
    {
        [JsonProperty("code")]
        private int? code;

        [JsonProperty("status")]
        private int? status;

        [JsonProperty("message")]
        private string message;

        public int Status
        {
            get
            {
                return this.status ?? this.code ?? default(int);
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