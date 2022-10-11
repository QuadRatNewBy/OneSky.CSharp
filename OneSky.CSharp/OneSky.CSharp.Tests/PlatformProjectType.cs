namespace OneSky.CSharp.Tests
{
    using FluentAssertions;

    using OneSky.CSharp.Json;

    using Xunit;

    public class PlatformProjectType
    {
        private static IPlatformProjectType projectType = OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Platform.ProjectType;

        [Fact]
        public void List()
        {
            var response = projectType.List();

            response.Should().NotBeNull(". Null response is unexpected");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.Meta.Should().NotBeNull(". [Platform].[ProjectType].[List] should response with non-empty meta.");
            response.Meta.Status.Should().Be(response.StatusCode, ". A assume that's just how it should be");
            response.Meta.RecordCount.Should().BePositive(". Expecting non-empty list");

            response.Data.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.HaveCount(response.Meta.RecordCount, ". A assume that's just how it should be")
                .And.Contain(x => x.Code == "game-unity", "as my reason to use OneSky")
                .And.Contain(
                    x => x.Code.EndsWith("-others"),
                    "to have ability to use 'other' types of course");
        }
    }
}