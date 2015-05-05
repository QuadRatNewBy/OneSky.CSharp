namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformProjectTypeExample
    {
        public static void ProjectTypePlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var projectTypes = oneSky.Platform.ProjectType.List();
            Console.WriteLine(projectTypes);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}