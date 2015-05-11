namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginOrderExample
    {
        public static void OrdersPlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var orders = oneSky.Plugin.Order.GetOrders(66001);
            Console.WriteLine(orders);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void OrderPlainPost()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var items = "{\"item1\": {\"title\": \"item1_title\",\"content\": \"item1_content\"},\"item2\": {\"title\": \"item2_title\",\"content\": \"item2_content\"}}";
            var orders = oneSky.Plugin.Order.PostOrders(66001, "en", "fr,de", items);
            Console.WriteLine(orders);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}