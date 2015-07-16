namespace OneSkyDotNetTests
{
    using System.Collections.Generic;

    using FluentAssertions;

    using Xunit;

    public class PluginLocales
    {
        private static OneSkyDotNet.Json.IPluginLocale locale = OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.Locale;

        [Fact]
        public void GetLocales()
        {
            var response = locale.GetLocales();

            response.Should().NotBeNull(". Null response is unexpected");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.DataContent.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.Contain(x => x.Locale == "be", "because I care for my language")
                .And.Contain(
                    x => (new List<string> { "pl", "en", "de", "uk", "ga", "ru", "es", "fr" }).Contains(x.Locale),
                    "because I want to have those languages")
                .And.Contain(x => x.Code == "zh-TW", "as homage to OneSky(documentation)");
        }
    }
}