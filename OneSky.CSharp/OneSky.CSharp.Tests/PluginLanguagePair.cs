namespace OneSky.CSharp.Tests
{
    using FluentAssertions;

    using OneSky.CSharp.Json;

    using Xunit;

    public class PluginLanguagePair
    {
        private static IPluginLanguagePair languagePair = OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.LanguagePair;

        [Fact]
        public void GetLanguagePairs()
        {
            var response = languagePair.GetLanguagePairs("en");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.Data.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.Contain(x => x.Code == "de");
        }
    }
}