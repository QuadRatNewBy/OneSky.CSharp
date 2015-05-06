namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PluginSpecializationExplain
    {
        public static void SpecializationsPlainGet()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey);
            var specs = oneSky.Plugin.Specialization.GetSpecializations();
            Console.WriteLine(specs);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}