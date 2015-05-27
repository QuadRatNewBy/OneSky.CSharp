namespace OneSkyDotNetExamples.Json
{
    using System;
    using System.Linq;

    public static class AppDescription
    {
        public static void Demo()
        {
            var client = OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var clientPlain = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);

            var appDescriptionProjects = client.Platform.Project.List(32182).DataContent.Select(x => x.Id);

            foreach (var appDescriptionProject in appDescriptionProjects)
            {
                var projectType = client.Platform.Project.Show(appDescriptionProject).DataContent.ProjectType;
                Console.WriteLine("[{0}] {1}/{2}", appDescriptionProject, projectType.Code, projectType.Name);

                var appDesc = clientPlain.Platform.Translation.AppDescription(appDescriptionProject, "en");
                Console.WriteLine(appDesc);
            }
        }
    }
}