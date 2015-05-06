namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginProjectExample
    {
        public static void ProjectsPlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var projects = oneSky.Plugin.Project.GetProjects();
            Console.WriteLine(projects);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void ProjectPlainPost()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var postProject1 = oneSky.Plugin.Project.PostProject("Plugin Proj Test1");
            var postProject = oneSky.Plugin.Project.PostProject("Plugin Proj Test");
            Console.WriteLine(postProject);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

    }
}