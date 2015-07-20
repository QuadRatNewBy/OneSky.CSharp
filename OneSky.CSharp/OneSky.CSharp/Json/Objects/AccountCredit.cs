#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
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