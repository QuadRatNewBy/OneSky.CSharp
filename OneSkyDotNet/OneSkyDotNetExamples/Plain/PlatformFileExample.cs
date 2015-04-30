namespace OneSkyDotNetExamples.Plain
{
    using System;

    public class PlatformFileExample
    {
        private static int projectId = 56704;

        public static void OrderPlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var files = oneSky.Platform.File.List(projectId, 1, 1);
            Console.WriteLine(files);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        } 
    }
}