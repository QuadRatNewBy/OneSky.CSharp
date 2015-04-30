namespace OneSkyDotNetExamples.Plain
{
    using System;

    public static class PlatformTranslationExamples
    {
        private static int projectId = 56704;

        public static void TranslationPlainExport()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var translation = oneSky.Platform.Translation.Export(projectId, "de", "Main.txt");
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
    }
}