namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformTranslationExamples
    {
        private static int projectId = 56704;

        public static void TranslationPlainExport()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var translation = oneSky.Platform.Translation.Export(projectId, "en", "Main.txt");
            Console.WriteLine(translation);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void TranslationPlainExportMultilingualFile()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var translation = oneSky.Platform.Translation.ExportMultilingualFile(
                projectId,
                "Book1.xlsx",
                fileFormat: "I18NEXT_MULTILINGUAL_JSON");
            Console.WriteLine(translation);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void TranslationPlainAppDescription()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var translation = oneSky.Platform.Translation.AppDescription(64702, "en");
            Console.WriteLine(translation);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static void TranslationPlainStatus()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var status = oneSky.Platform.Translation.Status(projectId, "Main.txt", "de");
            Console.WriteLine(status);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}