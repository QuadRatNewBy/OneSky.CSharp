namespace OneSkyDotNetTests
{
    using FluentAssertions;

    using Xunit;

    public class PluginAccount
    {
        private OneSkyDotNet.Json.IPluginAccount account =
            OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.Account;

        [Fact]
        public void Credits()
        {
            var response = this.account.GetCredit();

            response.StatusCode.Should().BeInRange(200, 299);

            response.DataContent.RemainingCredit.Should().BeGreaterOrEqualTo(0);
        }
    }
}