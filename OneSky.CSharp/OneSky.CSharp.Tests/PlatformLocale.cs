namespace OneSkyDotNetTests
{
    using System.Collections.Generic;

    using FluentAssertions;

    using Xunit;

    public class PlatformLocale
    {
        private static OneSkyDotNet.Json.IPlatformLocale locale = OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Platform.Locale;

        [Fact]
        public void List()
        {
            var response = locale.List();

            response.Should().NotBeNull(". Null response is unexpected");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.MetaContent.Should().NotBeNull(". [Platform].[Locale].[List] should response with non-empty meta.");
            response.MetaContent.Status.ShouldBeEquivalentTo(response.StatusCode, ". A assume that's just how it should be");
            response.MetaContent.RecordCount.Should().BePositive(". Expecting non-empty list");

            response.DataContent.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.HaveCount(response.MetaContent.RecordCount, ". A assume that's just how it should be")
                .And.Contain(x => x.Locale == "be", "because I care for my language")
                .And.Contain(
                    x => (new List<string> { "pl", "en", "de", "uk", "ga", "ru", "es", "fr" }).Contains(x.Locale),
                    "because I want to have those languages")
                .And.Contain(x => x.Code == "zh-TW", "as homage to OneSky(documentation)");
        }
    }
}