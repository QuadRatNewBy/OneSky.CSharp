namespace OneSky.CSharp.Tests
{
    using FluentAssertions;

    using OneSky.CSharp.Json;

    using Xunit;

    public class PluginAnonymous
    {
        private IPluginAnonymous anonymous = OneSkyClient.Anonymous;

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