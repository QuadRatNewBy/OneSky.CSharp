namespace OneSkyDotNetExamples.Plain
{
    using System;
    using System.Collections.Generic;

    public static class PlatformProjectExample
    {
        public static void ProjectPlainList()
        {
            var projectGroupId = 24856;
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var projects = oneSky.Platform.Project.List(projectGroupId);
            Console.WriteLine(projects);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainShow()
        {
            var projectId = 56704;
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Show(projectId);
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainCreate()
        {
            var projectGroupId = 24856;
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
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
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Update(projectId, "Proj update Name", "Proj update Desc");
            Console.WriteLine(project);

            project = oneSky.Platform.Project.Show(projectId);
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainDelete()
        {
            var projectId = 63486;
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var project = oneSky.Platform.Project.Delete(projectId);
            Console.WriteLine(project);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainLanguages()
        {
            var projectId = 56704;
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var projectlangs = oneSky.Platform.Project.Languages(projectId);
            Console.WriteLine(projectlangs);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainShowMultiple()
        {
            var list = new List<int> { 65476, 65455, 65458, 65467, 65470, 65452, 65473 };
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            foreach (var i in list)
            {
                var project = oneSky.Platform.Project.Show(i);
                Console.WriteLine(project);
            }
            Console.ReadKey();
        }
    }
}