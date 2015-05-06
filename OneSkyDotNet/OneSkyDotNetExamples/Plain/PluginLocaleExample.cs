namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginLocaleExample
    {
        public static void LocalePlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var locales = oneSky.Plugin.Locale.GetLocales();
            Console.WriteLine(locales);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}