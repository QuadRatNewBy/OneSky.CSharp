namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformImportTaskExample
    {
        private static int projectId = 56704;

        public static void TaskPlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var importTasks = oneSky.Platform.ImportTask.List(projectId, 2, 2);
            Console.WriteLine(importTasks);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void TaskPlainShow()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var importTask = oneSky.Platform.ImportTask.Show(projectId, 190588);
            Console.WriteLine(importTask);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}