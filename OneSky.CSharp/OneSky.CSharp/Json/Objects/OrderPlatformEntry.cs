namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class OrderPlatformEntry : Order, IOrderPlatformEntry
    {
        [JsonProperty("status")]
        private string status;

        public string Status
        {
            get
            {
                return this.status;
            }
        }
    }
}