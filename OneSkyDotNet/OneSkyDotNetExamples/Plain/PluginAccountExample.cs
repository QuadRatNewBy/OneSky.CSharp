namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginAccountExample
    {
        public static void CreditPlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var credit = oneSky.Plugin.Account.GetCredit();
            Console.WriteLine(credit);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}