namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class OrderPlugin : Order, IOrderPlugin
    {
        [JsonProperty("amount")]
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }
    }
}