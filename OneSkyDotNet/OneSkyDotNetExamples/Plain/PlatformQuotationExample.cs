namespace OneSkyDotNetExamples.Plain
{
    using System;
    using System.Collections.Generic;

    public static class PlatformQuotationExample
    {
        public static void QuotationPlainShow()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var quotation = oneSky.Platform.Quotation.Show(
                56704,
                new List<string> { "zecond.txt" },
                "de",
                specialization: "game");
            Console.WriteLine(quotation);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}