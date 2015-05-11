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

        public static void PlainSingUp()
        {
            var singUp = OneSkyDotNet.OneSkyClient.Anonymous.SingUp("email@server.some");
            Console.WriteLine(singUp);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void PlainSingIn()
        {
            var singIn = OneSkyDotNet.OneSkyClient.Anonymous.SingIn("email@server.some", "password");
            Console.WriteLine(singIn);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}