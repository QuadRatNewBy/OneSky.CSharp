namespace OneSkyDotNetExamples.Plain
{
    using System;
    using System.Collections.Generic;

    public static class PlatformOrderExample
    {
        private static int projectId = 56704;

        public static void OrderPlainList()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var orders = oneSky.Platform.Order.List(projectId, 1, 2);
            Console.WriteLine(orders);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void OrderPlainShow()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var order = oneSky.Platform.Order.Show(projectId, 1);
            Console.WriteLine(order);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void OrderPlainCreate()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var order = oneSky.Platform.Order.Create(projectId, new List<string> { "Main.txt" }, "fr", note: "!!!Please igrone this order!!! Its createted to test OneSky API. Thank you for your cooperation.",orderType: "review-only");
            Console.WriteLine(order);
            Console.WriteLine();
            order = oneSky.Platform.Order.Create(projectId, new List<string> { "Main.txt" }, "de", note: "!!!Please igrone this order!!! Its createted to test OneSky API. Thank you for your cooperation.", orderType: "review-only");
            Console.WriteLine(order);
            Console.WriteLine();
            order = oneSky.Platform.Order.Create(projectId, new List<string> { "Main.txt" }, "ru", note: "!!!Please igrone this order!!! Its createted to test OneSky API. Thank you for your cooperation.", orderType: "review-only");
            Console.WriteLine(order);
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}