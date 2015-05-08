namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginQuotationsExample
    {
        public static void QuotationPlainPost()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var items = "{\"item1\": {\"title\": \"item1_title\",\"content\": \"item1_content\"},\"item2\": {\"title\": \"item2_title\",\"content\": \"item2_content\"}}";
            var locales = oneSky.Plugin.Quotation.PostQuotations(66001, "en", "de,fr", items);
            Console.WriteLine(locales);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}