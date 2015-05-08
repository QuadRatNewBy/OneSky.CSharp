namespace OneSkyDotNetExamples.Plain
{
    using System;

    public class PluginItemExample
    {
        public static void ItemsPlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var items = oneSky.Plugin.Item.GetItems(66001);
            Console.WriteLine(items);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}