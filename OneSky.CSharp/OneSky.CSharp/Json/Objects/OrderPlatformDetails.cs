namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderPlatformDetails : OrderPlatform, IOrderPlatformDetails
    {
        [JsonProperty("status")]
        private string status;

        [JsonProperty("amount")]
        private decimal amount;

        [JsonProperty("tasks")]
        private IEnumerable<OrderTaskFullDetails> tasks;

        public string Status
        {
            get
            {
                return this.status;
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }

        public IEnumerable<IOrderTaskFullDetails> Tasks
        {
            get
            {
                return this.tasks;
            }
        }
    }
}