namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformLocaleExample
    {
        public static void LocalePlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var locales = oneSky.Platform.Locale.List();
            Console.WriteLine(locales);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}