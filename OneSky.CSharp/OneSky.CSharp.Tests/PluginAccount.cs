namespace OneSky.CSharp.Tests
{
    using FluentAssertions;

    using OneSky.CSharp.Json;

    using Xunit;

    public class PluginAccount
    {
        private IPluginAccount account =
            OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.Account;

        [Fact]
        public void Credits()
        {
            var response = this.account.GetCredit();

            response.StatusCode.Should().BeInRange(200, 299);

            response.DataContent.RemainingCredit.Should().BeGreaterOrEqualTo(0);
        }
    }
}