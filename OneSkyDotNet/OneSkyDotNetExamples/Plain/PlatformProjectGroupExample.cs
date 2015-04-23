namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformProjectGroupExample
    {
        public static void ProjectGroupPlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var projectGroups = oneSky.Platform.ProjectGroup.List();
            Console.WriteLine(projectGroups);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectGroupPlainShow()
        {
            var projectId = 24856;
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var projectGroup = oneSky.Platform.ProjectGroup.Show(projectId);
            Console.WriteLine(projectGroup);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}