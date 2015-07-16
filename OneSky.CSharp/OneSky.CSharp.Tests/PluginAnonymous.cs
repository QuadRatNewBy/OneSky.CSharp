namespace OneSkyDotNetTests
{
    using FluentAssertions;

    using Xunit;

    public class PluginAnonymous
    {
        private OneSkyDotNet.Json.IPluginAnonymous anonymous = OneSkyDotNet.Json.OneSkyClient.Anonymous;

        [Fact]
        public void Login()
        {
            var response = this.anonymous.SingIn(SettingsUser.Email, SettingsUser.Password);

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.DataContent.Should()
                .NotBeEmpty()
                .And.Contain(x => x.ApiKey == Settings.PublicKey && x.ApiSecret == Settings.PrivateKey);
        }
    }
}