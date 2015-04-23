namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformProjectGroupExample
    {
        public static void ProjectGroupPlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var projectGroup = oneSky.Platform.ProjectGroup.List();
            Console.WriteLine(projectGroup);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}