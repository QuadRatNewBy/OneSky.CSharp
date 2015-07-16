namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class AccountCredits : IAccountCredit
    {
        [JsonProperty("remaining_credit")]
        private decimal remainingCredit;

        public decimal RemainingCredit
        {
            get
            {
                return this.remainingCredit;
            }
        }
    }
}