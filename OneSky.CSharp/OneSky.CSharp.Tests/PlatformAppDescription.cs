namespace OneSky.CSharp.Tests
{
    using System.Linq;

    using FluentAssertions;

    using OneSky.CSharp.Json;

    using Xunit;

    public class PlatformAppDescription
    {
        private static IPlatform platform =
            OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Platform;

        // Redefine, if you've created App Description projects with different locale.
        private static readonly string Locale = "en";

        [Fact]
        public void All()
        {
            // *********************************************************************************
            // *** 1. Create new Project Group.
            // *** 2. Add various App Description projects on OneSkyApp.com (fill ALL fields)
            // *** 3. Replace this ID with yours.
            // *********************************************************************************
            var projectGroupId = 32182;

            var projects = platform.Project.List(projectGroupId).DataContent.ToArray();
            projects.Should().NotBeEmpty();

            foreach (var project in projects)
            {
                this.TestProject(project.Id);
            }
        }

        private void TestProject(int id)
        {
            var project = platform.Project.Show(id).DataContent;
            switch (project.ProjectType.Code)
            {
                case "itunes-metadata":
                    this.ItunesAppDescription(id);
                    break;
                case "android-market-metadata":
                    this.AndroidAppDescription(id);
                    break;
                case "windows-phone-marketplace-metadata":
                    this.WindowsAppDescription(id);
                    break;
                case "android-amazon-metadata":
                    this.AmazonAppDescription(id);
                    break;
                case "android-samsung-metadata":
                    this.SamsungAppDescription(id);
                    break;
                case "facebook-app-center-metadata":
                    this.FacebookAppDescription(id);
                    break;
            }
        }

        private void ItunesAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Description.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.RecentChanges.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Keywords.Should().NotBeEmpty("Some keywords for teting");
            appDescription.IapName.Should().NotBeEmpty("Some IAP names for teting");
            appDescription.IapDescription.Should().NotBeEmpty("Some IAP descriptions for teting");
        }

        private void AndroidAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Description.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.RecentChanges.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.ShortDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.IapName.Should().NotBeEmpty("Some IAP names for teting");
            appDescription.IapDescription.Should().NotBeEmpty("Some IAP descriptions for teting");
        }

        private void WindowsAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.DetailedDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.ShortDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Keywords.Should().NotBeEmpty("Some keywords for teting");
        }

        private void AmazonAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.DetailedDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.ShortDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Features.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Keywords.Should().NotBeEmpty("Some keywords for teting");
        }

        private void SamsungAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Description.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Tags.Should().NotBeEmpty("Some keywords for teting");
        }

        private void FacebookAppDescription(int id)
        {
            var appDescription = platform.Translation.AppDescription(id, Locale).DataContent;

            appDescription.Name.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.DetailedDescription.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Description.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
            appDescription.Tagline.Should().NotBeNullOrWhiteSpace("I guess you have filled all fields");
        }
    }
}