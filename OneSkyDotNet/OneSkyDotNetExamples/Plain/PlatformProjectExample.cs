namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformProjectExample
    {
        public static void ProjectPlainList()
        {
            var projectGroupId = 24856;
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var projects = oneSky.Platform.Project.List(projectGroupId);
            Console.WriteLine(projects);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainShow()
        {
            var projectId = 56704;
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Show(projectId);
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainCreate()
        {
            var projectGroupId = 24856;
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Create(
                projectGroupId,
                "website",
                "Proj create Name",
                "Proj create Desc");
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainUpdate()
        {
            var projectId = 57445;
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Update(projectId, "Proj update Name", "Proj update Desc");
            Console.WriteLine(project);

            project = oneSky.Platform.Project.Show(projectId);
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}