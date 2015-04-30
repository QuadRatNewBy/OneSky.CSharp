namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformFileExample
    {
        private static int projectId = 56704;

        public static void FilePlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var files = oneSky.Platform.File.List(projectId, 1, 1);
            Console.WriteLine(files);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
        
        public static void FilePlainUpload()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var file = oneSky.Platform.File.Upload(projectId, "Plain/TestFile.txt", "INI");
            Console.WriteLine(file);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void FilePlainDelete()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var file = oneSky.Platform.File.Delete(projectId, "TestFile.txt");
            Console.WriteLine(file);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}