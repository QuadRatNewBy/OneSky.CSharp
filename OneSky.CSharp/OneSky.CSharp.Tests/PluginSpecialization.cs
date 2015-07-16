namespace OneSkyDotNetTests
{
    using System.Collections.Generic;

    using FluentAssertions;

    using Xunit;

    public class PluginSpecialization
    {
        private static OneSkyDotNet.Json.IPluginSpecialization specialization = OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.Specialization;

        [Fact]
        public void GetSpecializations()
        {
            var response = specialization.GetSpecializations();

            response.Should().NotBeNull(". Null response is unexpected");

            response.StatusCode.Should().BeGreaterOrEqualTo(200).And.BeLessThan(300);

            response.DataContent.Should()
                .NotBeNullOrEmpty(". Expecting non-null and non-empty list")
                .And.Contain(x => x.Code == "game");
        } 
    }
}