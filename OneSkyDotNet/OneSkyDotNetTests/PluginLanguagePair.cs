namespace OneSkyDotNetTests
{
    using FluentAssertions;

    using Xunit;

    public class PluginLanguagePair
    {
        private static OneSkyDotNet.Json.IPluginLanguagePair languagePair = OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.LanguagePair;

        [Fact]
        public void GetLanguagePairsEn()
        {
            var response = languagePair.GetLanguagePairs("en");

            response.Should().NotBeNull(". Null response is unexpected");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.DataContent.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.Contain(x => x.Code == "de");
        }
    }
}